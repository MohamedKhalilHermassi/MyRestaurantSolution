using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UI.Web.Controllers
{
    public class ServeurController : Controller
    {
        IServiceServeur ss;
        IServiceRestaurant sr;

        public ServeurController(IServiceServeur ss, IServiceRestaurant sr)
        {
            this.ss = ss;
            this.sr = sr;
        }

        public ActionResult Index()
        {
            return View(ss.GetMany());
        }

        // GET: ServeurController/Details/5
        public ActionResult Details(int id)
        {
            return View(sr.GetById(id));
        }

        // GET: ServeurController/Create
        public ActionResult Create()
        {
            ViewBag.lsRestaurants = new SelectList(sr.GetMany(), "Id", "Nom");

            return View();
        }

        // POST: ServeurController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Serveur collection)
        {
            try
            {
                ss.Add(collection);
                ss.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ServeurController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ServeurController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ServeurController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ServeurController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
