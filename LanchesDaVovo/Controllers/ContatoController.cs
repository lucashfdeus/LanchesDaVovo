using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace LanchesDaVovo.Controllers
{
    public class ContatoController: Controller
    {
        public IActionResult Index()
        {
            return View();  
        }
    }
}
