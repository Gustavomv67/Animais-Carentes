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
    public class AgendamentoController : Controller
    {
        private contexto db = new contexto();

        // GET: Agendamento
        public ActionResult Index()
        {
            return View(db.AgendamentoModels.ToList());
        }

        // GET: Agendamento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgendamentoModel agendamentoModel = db.AgendamentoModels.Find(id);
            if (agendamentoModel == null)
            {
                return HttpNotFound();
            }
            return View(agendamentoModel);
        }

        // GET: Agendamento/Create/5
        public ActionResult Create(string cnpj)
        {
            if (cnpj == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            AgendamentoModel model = new AgendamentoModel();
            model.ong = db.OngModels.First(a => a.cnpj == cnpj);
            return View(model);
        }

        // POST: Agendamento/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,dataEntrega,usuarioEntrega,enderecoEntrega,animal")] AgendamentoModel agendamentoModel, string cnpj)
        {
            agendamentoModel.ong = db.OngModels.First(a => a.cnpj == cnpj);
            agendamentoModel.usuario = db.UsuarioModels.First();
            if (ModelState.IsValid)
            {  
                db.AgendamentoModels.Add(agendamentoModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(agendamentoModel);
        }

        // GET: Agendamento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgendamentoModel agendamentoModel = db.AgendamentoModels.Find(id);
            if (agendamentoModel == null)
            {
                return HttpNotFound();
            }
            return View(agendamentoModel);
        }

        // POST: Agendamento/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,dataEntrega,usuarioEntrega,enderecoEntrega,animal")] AgendamentoModel agendamentoModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agendamentoModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agendamentoModel);
        }

        // GET: Agendamento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgendamentoModel agendamentoModel = db.AgendamentoModels.Find(id);
            if (agendamentoModel == null)
            {
                return HttpNotFound();
            }
            return View(agendamentoModel);
        }

        // POST: Agendamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AgendamentoModel agendamentoModel = db.AgendamentoModels.Find(id);
            db.AgendamentoModels.Remove(agendamentoModel);
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
