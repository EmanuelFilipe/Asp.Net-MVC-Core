using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace DevIO.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        // método que será chamado durante a criação
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // colunas não mapeadas do tipo string serão criadas no sistema como varchar(max), que pode causar problemas de otimização no sistema.
            // esse método NÃO SOBRE ESCREVE ao mapeamento feito pela migration, so irá aplicar nas colunas que não mapeadas
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.Relational().ColumnType = "varchar(100)";

            // irá pegar o DbContext, buscar todas as entidades que estçao mapeadas nele e vai buscar classes que herdam de
            // IEntityTypeConfiguration para as entidades que estão relacionadas ao DbContext, registrando todas de uma vez
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

            // código abaixo é para evitar a efeito deleteCascade, por exemplo, ao deletar um fornecedor... todos os produtos que estavam relacionado a aquele fornecedor iria ser apagado automaticamente.
            // para cada FK encontrado nas entidades e atribuir o clientSetNull para cada deletebehavior encontrado
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}