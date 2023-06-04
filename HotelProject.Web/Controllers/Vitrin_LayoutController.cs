using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Controllers
{
    public class Vitrin_LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
