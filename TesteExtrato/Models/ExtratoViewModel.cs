using TesteExtrato.Abstracoes.ViewModels;

namespace TesteExtrato.Models
{
    public class ExtratoViewModel
    {
        public string? FiltroDias { get; set; }
        public IEnumerable<TransacaoDto>? Transacoes { get; set; }
    }
}
