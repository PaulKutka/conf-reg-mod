using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ConfReg.DataAcess;
using ConfReg.Domain;

namespace ConferenceRegistration.Controllers
{
    public class ParticipantsController : Controller
    {
        private ConfRegDb db = new ConfRegDb();

        public ActionResult Index()
        {
            return View(db.Participants.ToList());
        }

        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Degree,Name,Surname,Institution,Email,PhoneNumber,AnnName,AnnAuthorsAndAff,AnnSummary,RoomType,AccPerson,InvoiceReq")] Participants participants)
        {
            if (ModelState.IsValid)
            {
                db.Participants.Add(participants);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(participants);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Participants participants = db.Participants.Find(id);
            if (participants == null)
            {
                return HttpNotFound();
            }
            return View(participants);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Participants participants = db.Participants.Find(id);
            db.Participants.Remove(participants);
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
