using TesteExtrato.Dominio.Agregados.Base;

namespace TesteExtrato.Dominio.Agregados.AgregadoContaCorrente
{
    public class Transacao : ValueObject
    {
        public Transacao(DateTime data, TipoTransacao tipo, decimal valor)
        {
            Id = Guid.NewGuid();
            Data = data;
            Valor = valor;
            Tipo = tipo;
        }

        public Guid Id { get; private set; }
        public DateTime Data { get; private set; }
        public TipoTransacao Tipo { get; private set; }        
        public decimal Valor { get; private set; }
    }
}
