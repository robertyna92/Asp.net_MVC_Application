using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationApi.Models;

namespace WebApplicationApi.Controllers
{
    public class AccessiController : Controller
    {
        Database1Entities db = new Database1Entities();

        // GET: Accessi
        public ActionResult Index()
        {
            return View();
        }

        // GET: Accessi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Accessi/Create
        public ActionResult Create()
        {
        
            return View(db.Accessi.ToList().FindAll(userID => userID.id_utente.ToString() == Session["Id"].ToString()));

        }

        // POST: Accessi/Create
        [HttpPost]
        public ActionResult Create( FormCollection form)
        {

            return View();
            
        }

        // GET: Accessi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Accessi/Edit/5
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

        // GET: Accessi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Accessi/Delete/5
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
