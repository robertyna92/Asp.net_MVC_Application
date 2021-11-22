using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationApi.Models;

namespace WebApplicationApi.Controllers
{
    public class DashboardController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: Dashboard
        public ActionResult Index(int? id)
        {
            return View(db.Persone.ToList().FindAll(email => email.email == Session["email"].ToString()));
        }

        // GET: Dashboard/Details/5
        public ActionResult Details()
        {          
            return RedirectToAction("Details","Prodotti");
        }

        // GET: Dashboard/Create
        public ActionResult Create()
        {
            return RedirectToAction("Create", "Accessi");
        }

        // POST: Dashboard/Create
        [HttpPost]
        public ActionResult Create(FormCollection formCollection )
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dashboard/Edit/5
        public ActionResult Edit(int? id)
        {         
            if(Session["Id"] == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }         
            Persone persone = db.Persone.Find(id);         
            if(persone == null)
            {
                return HttpNotFound();
            }
          
            return View(persone);
        }

        // POST: Dashboard/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include ="Id, name, surname, email, password, city, address")] Persone persona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(persona).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
                return View();       
        }

        // GET: Dashboard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dashboard/Delete/5
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
