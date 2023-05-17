using Location_voiture_COMMON.Repositories;
using Location_voitures.Handlers;
using Location_voitures.Models.VoitureModelView;
using Location_voitures_BLL.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location_voitures.Controllers
{
    public class VoitureController : Controller
    {
        // GET: VoitureController
        private readonly IVoitureRepository<Voiture, int> _services;

        public VoitureController(IVoitureRepository<Voiture, int> services)
        {
            _services = services;
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: VoitureController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VoitureController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VoitureController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VoitureCreateForm form)
        {
            if (!ModelState.IsValid)
            {
                
                return View(form);
            }
            else
            {
                int id = _services.Insert(form.toBLL());
                

                return RedirectToAction("Détails", "Voiture", new { id = id });

            }
        }

        // GET: VoitureController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VoitureController/Edit/5
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

        // GET: VoitureController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VoitureController/Delete/5
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
