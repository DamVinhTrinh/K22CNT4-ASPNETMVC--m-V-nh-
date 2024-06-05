using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dvtlesso06FCK22CNTT4.Models;

namespace Dvtlesso06FCK22CNTT4.Controllers
{
    public class DvtBooksController : Controller
    {
        private DvtBookStore db = new DvtBookStore();

        // GET: DvtBooks
        public ActionResult Index()
        {
            return View(db.DvtBooks.ToList());
        }

        // GET: DvtBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DvtBook dvtBook = db.DvtBooks.Find(id);
            if (dvtBook == null)
            {
                return HttpNotFound();
            }
            return View(bhpBook);
        }

        // GET: DvtBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DvtBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DvtId,DvtBookId,DvtTitle,DvtAuthor,DvtYear,DvtPulisher,DvtPicture,DvtcategoryId")] DvtBook dvtBook)
        {
            if (ModelState.IsValid)
            {
                db.DvtBooks.Add(bvtBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dvtBook);
        }

        // GET: DvtBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DvtBook dvtBook = db.DvtBooks.Find(id);
            if (dvtBook == null)
            {
                return HttpNotFound();
            }
            return View(bhpBook);
        }

        // POST: DvtBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DvtId,DvtBookId,DvtTitle,DvtAuthor,DvtYear,DvtPulisher,DvtPicture,DvtcategoryId")] DvtBook dvtBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dvtBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dvtBook);
        }

        // GET: DvtBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DvtBook dvtBook = db.DvtBooks.Find(id);
            if (dvtBook == null)
            {
                return HttpNotFound();
            }
            return View(dvtBook);
        }

        // POST: DvtBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DvtBook bhpBook = db.DvtBooks.Find(id);
            db.DvtBooks.Remove(dvtBook);
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
