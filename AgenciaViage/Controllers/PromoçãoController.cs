using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaViage.Controllers
{
    public class PromoçãoController : Controller
    {
        // GET: PromoçãoController
        public ActionResult Promoções()
        {
            return View();
        }

        // GET: PromoçãoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PromoçãoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PromoçãoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Promoções));
            }
            catch
            {
                return View();
            }
        }

        // GET: PromoçãoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PromoçãoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Promoções));
            }
            catch
            {
                return View();
            }
        }

        // GET: PromoçãoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PromoçãoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Promoções));
            }
            catch
            {
                return View();
            }
        }
    }
}
