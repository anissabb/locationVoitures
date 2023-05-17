using Location_voiture_COMMON.Repositories;
using Location_voitures.Handlers;
using Location_voitures.Models.ClientModelView;
using Location_voitures_BLL.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location_voitures.Controllers
{
    public class ClientController : Controller
    {
        // GET: ClientController
        private readonly IClientRepository<Client, int> _services;

        public ClientController(IClientRepository<Client, int> services)
        {
            _services = services;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            ClientDetails model = _services.Get(id).ToDetails();
            if (model is null)
            {
                TempData["Error"] = "Client inexistant";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult ClientCompte(int id)
        {
            ClientCompte model = _services.Get(id).ToClientCompte();

           
           if (model is null)
            {
                TempData["Error"] = "administrateur inexistant";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientCreateForm form)
        {
            if (!ModelState.IsValid)
            {
                form.MotdePasse = null;
                form.ConfirmMotdePasse = null;
                return View(form);
            }
            else
            {
                int id = _services.Insert(form.ToBLL());
                if ((form.AdresseMail== "admin@hotmail.com") &&(form.MotdePasse== "admin"))
                {
                    return RedirectToAction("ClientCompte", "Client", new { id = id });
                }
                
                return RedirectToAction("Détails","Client",new {id=id});
                
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
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

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
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
