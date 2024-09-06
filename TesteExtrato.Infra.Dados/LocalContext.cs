using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection.Metadata;
using TesteExtrato.Dominio.Agregados.AgregadoPessoa;

namespace TesteExtrato.Infra.Dados
{
    public class LocalContext: DbContext
    {
        public static string SCHEMA => "teste_extrato";

        public LocalContext(DbContextOptions<LocalContext> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(SCHEMA);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public class IntegrationContextFactory : IDesignTimeDbContextFactory<LocalContext>
        {
            public IntegrationContextFactory()
            {
            }

            public LocalContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<LocalContext>();
                optionsBuilder.UseSqlServer("Server=localhost;Database=TesteExtrato;Trusted_Connection=True;Trust Server Certificate = true");

                return new LocalContext(optionsBuilder.Options);
            }
        }
    }
}
