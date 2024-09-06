using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using TesteExtrato.Abstracoes.Queries;
using TesteExtrato.Abstracoes.Servicos;
using TesteExtrato.Abstracoes.ViewModels;

namespace TesteExtrato.Aplicacao.Servicos
{
    public class ServicoExtrato : IServicoExtrato
    {
        private IExtratoQuery query;

        public ServicoExtrato(IExtratoQuery query)
        {
            this.query = query;
        }

        public Task<IEnumerable<TransacaoDto>> ConsultarExtrato(string agencia, string numeroConta, int dias)
        {
            var dataInicio = DateTime.Now.Date.AddDays(-dias);

            return query.Get(agencia, numeroConta, dataInicio);
        }

        public async Task<MemoryStream> GerarPdf(string agencia, string numeroConta, int dias)
        {
            var dataInicio = DateTime.Now.Date.AddDays(-dias);
            var transacoes = await query.Get(agencia, numeroConta, dataInicio);

            QuestPDF.Settings.License = LicenseType.Community;

            var stream = new MemoryStream();

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Header()
                        .Text("Extrato")
                        .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

                    page.Content()
                        .Padding(10)
                        .Border(1)
                        .Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(100);
                                columns.RelativeColumn(250);
                                columns.ConstantColumn(200);
                            });

                            table.Cell().Text("Data");
                            table.Cell().Text("Transação");
                            table.Cell().Text("Valor");

                            foreach (var transacao in transacoes)
                            {
                                table.Cell().Text(transacao.Data.ToString("dd/MM"));
                                table.Cell().Text(transacao.TipoTransacao);
                                table.Cell().Text(transacao.Valor.ToString("C"));
                            }
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Página ");
                            x.CurrentPageNumber();
                        });
                });
            })
            .GeneratePdf(stream);

            return stream;
        }
    }
}
