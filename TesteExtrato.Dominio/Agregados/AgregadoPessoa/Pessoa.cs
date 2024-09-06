using TesteExtrato.Dominio.Agregados.Base;

namespace TesteExtrato.Dominio.Agregados.AgregadoPessoa
{
    public class Pessoa : Entidade
    {
        public Pessoa(Guid id)
        {
            Id = id;        
        }

        public string Nome { get; set; } = string.Empty;
    }
}
