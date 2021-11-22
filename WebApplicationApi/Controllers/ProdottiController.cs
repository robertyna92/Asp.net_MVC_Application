using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationApi.Models;

namespace WebApplicationApi.Controllers
{
    public class ProdottiController : Controller
    {


        // GET: Prodotti
        public ActionResult Index()
        {
            return View();
        }

        // GET: Prodotti/Details/5
        public ActionResult Details()
        {
            Database1Entities db = new Database1Entities();
            return View(db.Prodotti.ToList());
        }

        // GET: Prodotti/Create
        public ActionResult Create(int id, Prodotti prodotti)
        {
            Database1Entities db = new Database1Entities();
            int obj =  Convert.ToInt32(Session["Id"]);
            

            Preferiti preferiti = new Preferiti
            {
                id_prodotto = id,
                id_utente = obj
               
            };
            db.Preferiti.Add(preferiti);
            db.SaveChanges();
            
            var result = db.Prodotti.Where(ID => ID.Id == preferiti.id_prodotto);
            

            Debug.WriteLine(result);
            //if(prodotti.Id == preferiti.id_prodotto)
            //{

            //    var prod = prodotti.nome_prodotto;
            //    return RedirectToAction("Create", "Preferiti", prod);

            //}
            return View();           
            
        }
    
        public ActionResult Delete()
        {
            return RedirectToAction("Delete", "Preferiti");
        }    
    }
}
