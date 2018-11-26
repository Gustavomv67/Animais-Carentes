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
    public class AnimalController : Controller
    {
        private contexto db = new contexto();

        // GET: Animal
        public ActionResult Index()
        {
            return View(db.AnimalModels.ToList());
        }

        // GET: Animal/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalModel animalModel = db.AnimalModels.Find(id);
            if (animalModel == null)
            {
                return HttpNotFound();
            }
            return View(animalModel);
        }

        // GET: Animal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Animal/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,especie,raca,descricao")] AnimalModel animalModel)
        {
            if (ModelState.IsValid)
            {
                db.AnimalModels.Add(animalModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(animalModel);
        }

        // GET: Animal/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalModel animalModel = db.AnimalModels.Find(id);
            if (animalModel == null)
            {
                return HttpNotFound();
            }
            return View(animalModel);
        }

        // POST: Animal/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,especie,raca,descricao")] AnimalModel animalModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(animalModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(animalModel);
        }

        // GET: Animal/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalModel animalModel = db.AnimalModels.Find(id);
            if (animalModel == null)
            {
                return HttpNotFound();
            }
            return View(animalModel);
        }

        // POST: Animal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AnimalModel animalModel = db.AnimalModels.Find(id);
            db.AnimalModels.Remove(animalModel);
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
