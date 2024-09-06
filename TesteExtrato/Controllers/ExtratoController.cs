using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using TesteExtrato.Abstracoes.Servicos;
using TesteExtrato.Models;

namespace TesteExtrato.Controllers
{
    public class ExtratoController : Controller
    {
        private readonly IServicoExtrato service;

        public ExtratoController(IServicoExtrato service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index(ExtratoViewModel extrato)
        {
            if (extrato is null)
            {
                extrato = new ExtratoViewModel();
            }

            if (!int.TryParse(extrato.FiltroDias, out var dias))
            {
                dias =  5;
            }

            extrato.Transacoes = await service.ConsultarExtrato("0001", "000001-01", dias);

            return View(extrato);
        }

        public async Task<FileResult> Download(string? dias)
        {
            int filtroDia;
            if (string.IsNullOrEmpty(dias) || !int.TryParse(dias, out filtroDia))
            {
                filtroDia = 5;
            }
            
            var stream = await service.GerarPdf("0001", "000001-01", filtroDia);

            var bytes = stream.ToArray();
            string contentType = "application/pdf";
            return File(bytes, contentType, "Extrato.pdf");
        }
    }
}
