using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class haberlesmeController : Controller
    {
        Context c = new Context();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult mesajgonder(haberlesme i)
        {
            c.haberlesmes.Add(i);
            c.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
    }
}
