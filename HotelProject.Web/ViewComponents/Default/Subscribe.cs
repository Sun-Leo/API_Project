using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.ViewComponents.Default
{
    public class Subscribe: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
