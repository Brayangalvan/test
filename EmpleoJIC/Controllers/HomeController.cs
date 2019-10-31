namespace EmpleoJIC.Controllers
{
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private readonly Context db = new Context();

        // GET: Home
        public ActionResult Index(/*User user = null*/)
        {
            List<PraticalOffers> practicalOffers = db.PraticalOffers.ToList();
            foreach (var practical in practicalOffers)
            {
                practical.Profile = db.Profile.Find(practical.IdProfile);
                practical.Company = db.Companys.Find(practical.IdCompany);
            }
            return View(practicalOffers);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }
    }
}