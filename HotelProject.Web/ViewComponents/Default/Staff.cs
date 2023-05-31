using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.ViewComponents.Default
{
    public class Staff: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
