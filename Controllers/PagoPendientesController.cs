using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalProy.Models;

namespace FinalProy.Controllers
{
    public class PagoPendientesController : Controller
    {
        private FinalWebProyectEntities1 db = new FinalWebProyectEntities1();

        // GET: PagoPendientes
        public ActionResult Index()
        {
            return View(db.PagoPendiente.ToList());
        }

        // GET: PagoPendientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PagoPendiente pagoPendiente = db.PagoPendiente.Find(id);
            if (pagoPendiente == null)
            {
                return HttpNotFound();
            }
            return View(pagoPendiente);
        }

        // GET: PagoPendientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PagoPendientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPagoPendiente,totalPago,CedulaEnMora")] PagoPendiente pagoPendiente)
        {
            if (ModelState.IsValid)
            {
                db.PagoPendiente.Add(pagoPendiente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pagoPendiente);
        }

        // GET: PagoPendientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PagoPendiente pagoPendiente = db.PagoPendiente.Find(id);
            if (pagoPendiente == null)
            {
                return HttpNotFound();
            }
            return View(pagoPendiente);
        }

        // POST: PagoPendientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPagoPendiente,totalPago,CedulaEnMora")] PagoPendiente pagoPendiente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pagoPendiente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pagoPendiente);
        }

        // GET: PagoPendientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PagoPendiente pagoPendiente = db.PagoPendiente.Find(id);
            if (pagoPendiente == null)
            {
                return HttpNotFound();
            }
            return View(pagoPendiente);
        }

        // POST: PagoPendientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PagoPendiente pagoPendiente = db.PagoPendiente.Find(id);
            db.PagoPendiente.Remove(pagoPendiente);
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
