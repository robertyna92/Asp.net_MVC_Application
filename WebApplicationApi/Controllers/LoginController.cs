using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationApi.Models;

namespace WebApplicationApi.Controllers
{
    public class LoginController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(Persone persone)
        {
            if (ModelState.IsValid)
            {                 
                    var obj = db.Persone.Where(a => a.email.Equals(persone.email) && a.password.Equals(persone.password)).FirstOrDefault();    
                    if (obj != null)
                    {                      
                        Session["Id"] = obj.Id.ToString();
                        Session["name"] = obj.name.ToString();
                        Session["surname"] = obj.surname.ToString();
                        Session["email"] = obj.email.ToString();
                        Session["password"] = obj.password.ToString();
                        Session["city"] = obj.city.ToString();
                        Session["address"] = obj.address.ToString();
                    int userID = obj.Id;

                    Accessi accessi = new Accessi();
                    accessi.id_utente = userID;                                 
                    accessi.datatime = DateTime.Now;

                    db.Accessi.Add(accessi);
                    db.SaveChanges();
                    
                    return RedirectToAction("Index","DashBoard");
                    }
                
            }
            Response.Write("<script>alert('User not exsist ')</script>");
            return View(persone);
        }

     
        // GET: Login/Edit/5
        public ActionResult Edit(int? id)
        {
           
            return View(id);
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit()
        {
  
            return View();
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
