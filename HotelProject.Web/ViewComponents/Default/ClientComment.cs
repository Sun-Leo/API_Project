using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.ViewComponents.Default
{
    public class ClientComment: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
