using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace demo_mvc.ViewComponents
{
  [ViewComponent(Name = "Carrinho")]
  public class CarrinhoViewComponent : ViewComponent
  {
    public int ItensCarrinhos { get; set; }
    public CarrinhoViewComponent()
    {
      ItensCarrinhos = 3;
    }
    public async Task<IViewComponentResult> InvokeAsync(){
      return View(ItensCarrinhos);
    }
  }
}