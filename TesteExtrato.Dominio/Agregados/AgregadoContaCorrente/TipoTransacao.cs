
namespace TesteExtrato.Dominio.Agregados.AgregadoContaCorrente
{
    public class TipoTransacao
    {
        public static TipoTransacao ValorDepositado = new TipoTransacao(1, "Valor depositado");
        public static TipoTransacao ValorSacado = new TipoTransacao(2, "Valor sacado");
        public static TipoTransacao TransferenciaRecebida = new TipoTransacao(3, "Transferência recebida");
        public static TipoTransacao TransferenciaEnviada = new TipoTransacao(4, "Transferência enviada");
        public static TipoTransacao PagamentoRealizado = new TipoTransacao(5, "Pagamento realizado");

        public TipoTransacao(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public static IEnumerable<TipoTransacao> List()
        {
            yield return ValorDepositado;
            yield return ValorSacado;
            yield return TransferenciaRecebida;
            yield return TransferenciaEnviada;
            yield return PagamentoRealizado;
        }

        public static TipoTransacao FromId(int id) => List().FirstOrDefault(x => x.Id == id) ?? new TipoTransacao(id, "Não definido");
    }
}

