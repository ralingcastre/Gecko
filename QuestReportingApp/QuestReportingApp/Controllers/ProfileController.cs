using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuestReportingApp.Models;

namespace QuestReportingApp.Controllers
{
    public class ProfileController : Controller
    {
        private QuestReportingDb db = new QuestReportingDb();

        //
        // GET: /Profile/

        public ActionResult Index()
        {
            return View(db.Organisations.ToList());
        }

        //
        // GET: /Profile/Details/5

        public ActionResult Details(int id = 0)
        {
            Organisation organisation = db.Organisations.Find(id);
            if (organisation == null)
            {
                return HttpNotFound();
            }
            return View(organisation);
        }

        //
        // GET: /Profile/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Profile/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Organisation organisation)
        {
            if (ModelState.IsValid)
            {
                db.Organisations.Add(organisation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(organisation);
        }

        //
        // GET: /Profile/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Organisation organisation = db.Organisations.Find(id);
            if (organisation == null)
            {
                return HttpNotFound();
            }
            return View(organisation);
        }

        //
        // POST: /Profile/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Organisation organisation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(organisation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(organisation);
        }

        //
        // GET: /Profile/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Organisation organisation = db.Organisations.Find(id);
            if (organisation == null)
            {
                return HttpNotFound();
            }
            return View(organisation);
        }

        //
        // POST: /Profile/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Organisation organisation = db.Organisations.Find(id);
            db.Organisations.Remove(organisation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}