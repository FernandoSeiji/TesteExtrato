using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data.Common;
using System.Data;
using TesteExtrato.Infra.Dados;
using static TesteExtrato.Infra.Dados.LocalContext;

namespace TesteExtrato.Infra
{
    public static class CofigurarBanco
    {
        public static IServiceCollection AddDatabaseServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LocalContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Banco")));

            return services;
        }
    }
}
