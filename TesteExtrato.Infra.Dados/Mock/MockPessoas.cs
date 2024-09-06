using TesteExtrato.Dominio.Agregados.AgregadoPessoa;

namespace TesteExtrato.Infra.Dados.Mock
{
    public static class MockPessoas
    {
        public static IEnumerable<Pessoa> Mock()
        {
            yield return new Pessoa(new Guid("9e7141df-68ca-4998-b663-d0d5fdbacf2e")) { Nome = "Fernando"};
        }
    }
}
