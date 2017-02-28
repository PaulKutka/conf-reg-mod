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
        {                                                                               // ^ po Email turbut reik pridet ConfirmedEmail
            if (ModelState.IsValid)
            {
                //participants.ConfirmedEmail = false;
                db.Participants.Add(participants);
                db.SaveChanges();
                System.Net.Mail.MailMessage m = new System.Net.Mail.MailMessage(
                    new System.Net.Mail.MailAddress("sender@gmail.com", "Web Registration"), //Cia irgi deti siuntejo emaila
                    new System.Net.Mail.MailAddress(participants.Email));
                m.Subject = "Email confirmation";
                m.Body = string.Format("Dear {0} <BR/> Thank you for your registration, please click on the below link to complete your registration: <a href =\"{1}\" title =\"User Email Confirm\">{1}</a>",
                    participants.Name, Url.Action("ConfirmedEmail", "Participants",
                    new { id = participants.Id, Email = participants.Email },  Request.Url.Scheme)) ;
                m.IsBodyHtml = true;
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com"); //Jei naudojamas kazkas kitko, pakeisti gmail.com
                smtp.Credentials = new System.Net.NetworkCredential("sender@gmail.com", "password"); //pastas is kurio siunciama nurodyti emaila ir passworda
                smtp.EnableSsl = true;
                smtp.Send(m);
                return RedirectToAction("Confirm", new { Email = participants.Email });

                
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

        [AllowAnonymous]
        public ActionResult ConfirmedEmail(int id, string Email)
        {
           
            //db.Participants.Find(id).ConfirmedEmail = true;
            db.SaveChanges();
            return View();
                
        }

        [AllowAnonymous]
        public ActionResult Confirm(string Email)
        {
            ViewBag.Email = Email;
            return View();
        }

    }
}
