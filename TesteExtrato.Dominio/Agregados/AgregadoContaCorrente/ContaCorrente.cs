using TesteExtrato.Dominio.Agregados.Base;

namespace TesteExtrato.Dominio.Agregados.AgregadoContaCorrente
{
    public class ContaCorrente: Entidade
    {
        public ContaCorrente(Guid clienteId, string agencia, string numero)
        {
            ClienteId = clienteId;
            Agencia = agencia;
            Numero = numero;
        }

        public string Agencia { get; private set; }
        public string Numero { get; private set; }
        public Guid ClienteId { get; private set; }
        public decimal Saldo { get; private set; }

        private List<Transacao> _transacoes = new List<Transacao>();
        public virtual IReadOnlyList<Transacao> Transacoes => _transacoes.AsReadOnly();

        public void AdicionarTransacoes(TipoTransacao tipo, decimal valor, DateTime? date = null)
        {
            var transacao = new Transacao(date ?? DateTime.Now, tipo, valor);
            _transacoes.Add(transacao);

            Saldo += transacao.Valor;
        }
    }
}
