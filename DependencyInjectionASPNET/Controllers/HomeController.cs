using System.Web.Mvc;
using Business;

namespace DependencyInjectionASPNET.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVehicleService _service;

        public HomeController(IVehicleService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            var vehicles = _service.GetAll();

            return View(vehicles);
        }
    }
}