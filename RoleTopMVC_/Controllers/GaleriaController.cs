using Microsoft.AspNetCore.Mvc;
using RoleTopMVC_.ViewsModels;

namespace RoleTopMVC_.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Index()
        {
            return View(new BaseViewModel(){
                NomeView = "Galeria"
            });
        }
    }
}