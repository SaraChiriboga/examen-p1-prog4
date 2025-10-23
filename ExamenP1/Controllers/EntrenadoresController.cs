using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExamenP1.Models;

namespace ExamenP1.Controllers
{
    public class EntrenadoresController : Controller
    {
        private PokemonContext db = new PokemonContext();

        // GET: Entrenadores
        public ActionResult Index()
        {
            return View(db.Entrenadores.ToList());
        }

        // GET: Entrenadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entrenador entrenador = db.Entrenadores.Find(id);
            if (entrenador == null)
            {
                return HttpNotFound();
            }
            return View(entrenador);
        }

        // GET: Entrenadores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entrenadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NombreEntrenador,Region,Edad,PokemonId")] Entrenador entrenador)
        {
            if (ModelState.IsValid)
            {
                db.Entrenadores.Add(entrenador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entrenador);
        }

        // GET: Entrenadores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entrenador entrenador = db.Entrenadores.Find(id);
            if (entrenador == null)
            {
                return HttpNotFound();
            }
            return View(entrenador);
        }

        // POST: Entrenadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NombreEntrenador,Region,Edad,PokemonId")] Entrenador entrenador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entrenador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entrenador);
        }

        // GET: Entrenadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entrenador entrenador = db.Entrenadores.Find(id);
            if (entrenador == null)
            {
                return HttpNotFound();
            }
            return View(entrenador);
        }

        // POST: Entrenadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Entrenador entrenador = db.Entrenadores.Find(id);
            db.Entrenadores.Remove(entrenador);
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
