using demo_mvc.Models;
using Microsoft.AspNetCore.Mvc;


namespace demo_mvc.Controllers
{
  public class FilmesController : Controller
  {
    [HttpGet]
    public IActionResult Adicionar()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Adicionar(Filme filme)
    {
      if(ModelState.IsValid)
      {

      }

      return View(filme);
    }
  }
}