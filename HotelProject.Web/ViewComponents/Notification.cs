using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.ViewComponents
{
    public class Notification: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
