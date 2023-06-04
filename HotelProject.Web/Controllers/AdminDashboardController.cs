using HotelProject.Web.DTOS.StaffDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.Web.Controllers
{
    public class AdminDashboardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminDashboardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {

            return View();
        }

        
    }
}
