using Microsoft.AspNetCore.Mvc;

namespace ViewStartInCoreMvc.Controllers
{
    public class WorkerBookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
