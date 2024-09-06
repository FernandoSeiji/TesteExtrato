namespace TesteExtrato.Abstracoes.ViewModels
{
    public class TransacaoDto
    {
        public required DateTime Data { get; set; }
        public required string TipoTransacao { get; set; }
        public required decimal Valor { get; set; }
    }
}
