using TesteExtrato.Abstracoes.ViewModels;

namespace TesteExtrato.Abstracoes.Queries
{
    public interface IExtratoQuery
    {
        public Task<IEnumerable<TransacaoDto>> Get(string agencia, string numeroConta, DateTime dias);
    }
}
