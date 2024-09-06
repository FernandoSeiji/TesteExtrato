using TesteExtrato.Dominio.Agregados.AgregadoContaCorrente;

namespace TesteExtrato.Infra.Dados.Mock
{
    public static class MockContaCorrente
    {
        public static IEnumerable<ContaCorrente> Mock()
        {
            var contaCorrente = new ContaCorrente(new Guid("9e7141df-68ca-4998-b663-d0d5fdbacf2e"), "0001","000001-01");

            contaCorrente.AdicionarTransacoes(TipoTransacao.ValorDepositado, 1000, new DateTime(2024, 08, 18));
            contaCorrente.AdicionarTransacoes(TipoTransacao.PagamentoRealizado, -5, new DateTime(2024, 08, 19));
            contaCorrente.AdicionarTransacoes(TipoTransacao.PagamentoRealizado, -50, new DateTime(2024, 08, 20));
            contaCorrente.AdicionarTransacoes(TipoTransacao.PagamentoRealizado, -10, new DateTime(2024, 08, 25));
            contaCorrente.AdicionarTransacoes(TipoTransacao.TransferenciaEnviada, -60, new DateTime(2024, 09, 01));
            contaCorrente.AdicionarTransacoes(TipoTransacao.ValorSacado, -100, new DateTime(2024, 09, 05));

            yield return contaCorrente;
        }
    }
}
