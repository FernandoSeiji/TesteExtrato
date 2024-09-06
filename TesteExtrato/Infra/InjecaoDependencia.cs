using TesteExtrato.Abstracoes.Queries;
using TesteExtrato.Abstracoes.Servicos;
using TesteExtrato.Aplicacao.Servicos;
using TesteExtrato.Infra.Dados.Queries;

namespace TesteExtrato.Infra
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection AddServicos(this IServiceCollection services)
        {
            services.AddScoped<IServicoExtrato, ServicoExtrato>();

            return services;
        }

        public static IServiceCollection AddQueries(this IServiceCollection services)
        {
            services.AddScoped<IExtratoQuery, ExtratoQuery>();

            return services;
        }
    }
}
