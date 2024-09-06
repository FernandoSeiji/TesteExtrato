using TesteExtrato.Abstracoes.ViewModels;

namespace TesteExtrato.Abstracoes.Servicos
{
    public interface IServicoExtrato
    {
        Task<IEnumerable<TransacaoDto>> ConsultarExtrato(string agencia, string numeroConta, int dias);
        Task<MemoryStream> GerarPdf(string agencia, string numeroConta, int dias);
    }
}
