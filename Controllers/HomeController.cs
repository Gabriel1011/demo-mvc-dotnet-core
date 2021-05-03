using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using demo_mvc.Models;

namespace demo_mvc.Controllers
{
    [Route("")]
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("pagina-inicial")]
        public IActionResult Index(string id, string categoria)
        {
            var filme = new Filme(){
                Titulo = "oi",
                Datalancamento = DateTime.Now,
                Genero = "",
                Avaliacao = 6,
                Id = 1,
                Valor = 20000,
            };

            // return RedirectToAction("Privacy", filme);

            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy(Filme filme)
        {
            if(ModelState.IsValid){

            }

            foreach (var error in ModelState.Values.SelectMany(m=>m.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }

            // return Json("{'nome':'Gabriel'}");
            // var fileBytes = System.IO.File.ReadAllBytes("/home/gabriel/Documentos/aquecimento.csv");
            // var fileName = "arquivo.txt";
            // return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);

            // return Content("Qualquer coisa");

            return View();
        }

        [Route("erro-encotrado")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
