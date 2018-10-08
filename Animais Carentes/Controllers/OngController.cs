using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Animais_Carentes.Models;

namespace Animais_Carentes.Controllers
{
    public class OngController : Controller
    {
        private contexto db = new contexto();

        // GET: Ong
        public ActionResult Index()
        {
            return View(db.OngModels.ToList());
        }

        // GET: Ong/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OngModel ongModel = db.OngModels.Find(id);
            if (ongModel == null)
            {
                return HttpNotFound();
            }
            return View(ongModel);
        }

        // GET: Ong/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ong/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cnpj,nome,cep,estado,cidade,bairro,rua,numero,telefone,email,senha")] OngModel ongModel)
        {
            if (ModelState.IsValid)
            {
                db.OngModels.Add(ongModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ongModel);
        }

        // GET: Ong/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OngModel ongModel = db.OngModels.Find(id);
            if (ongModel == null)
            {
                return HttpNotFound();
            }
            return View(ongModel);
        }

        // POST: Ong/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cnpj,nome,cep,estado,cidade,bairro,rua,numero,telefone,email,senha")] OngModel ongModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ongModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ongModel);
        }

        // GET: Ong/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OngModel ongModel = db.OngModels.Find(id);
            if (ongModel == null)
            {
                return HttpNotFound();
            }
            return View(ongModel);
        }

        // POST: Ong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            OngModel ongModel = db.OngModels.Find(id);
            db.OngModels.Remove(ongModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
