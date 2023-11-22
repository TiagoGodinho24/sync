using Microsoft.AspNetCore.Mvc;

namespace TFSSincronizador.Controllers
{
    public class LoggingController : Controller
    {
        public IActionResult Log()
        {
            return View();
        }
    }
}
