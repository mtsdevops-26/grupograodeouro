using Microsoft.AspNetCore.Mvc;
using Gouro.WebApp.MVC.Models;

namespace Gouro.WebApp.MVC.Extensions
{
    public class PaginacaoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IPagedList modeloPaginado)
        {
            return View(modeloPaginado);
        }
    }
}