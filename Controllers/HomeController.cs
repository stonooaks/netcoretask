using Microsoft.AspNetCore.Mvc;

namespace netcoretask
{
    public class HomeController : Controller {

        public IActionResult Index(){
            return View();
        }
    }
}