namespace TesteExtrato.Dominio.Agregados.Base
{
    public abstract class Entidade
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();
    }
}
