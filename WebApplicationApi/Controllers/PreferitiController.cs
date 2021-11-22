using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationApi.Models;

namespace WebApplicationApi.Controllers
{
    public class PreferitiController : Controller
    {


        // GET: Preferiti
        public ActionResult Index()
        {
            return View();
        }

        // GET: Preferiti/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //GET: Preferiti/Create
        public ActionResult Create(Preferiti prefeiriti, Prodotti prodotto)
        {
            Database1Entities db = new Database1Entities();
            
            db.Prodotti.ToList().Find(ID => ID.Id == prefeiriti.Id);
            
            return View(prodotto.nome_prodotto);
            
        }

        // GET: Preferiti/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Preferiti/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Preferiti/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Preferiti/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
