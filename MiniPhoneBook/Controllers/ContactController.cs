using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniPhoneBook.Models;

namespace MiniPhoneBook.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            PhoneBookDbEntities4 db = new PhoneBookDbEntities4();
            List<Contact> list = db.Contacts.ToList();
            List<ContactViewModel> viewList = new List<ContactViewModel>();
            foreach (Contact s in list)
            {
                ContactViewModel obj = new ContactViewModel();
                obj.ContactId = s.ContactId;
                obj.ContactNumber = s.ContactNumber;
                obj.Type = s.Type;
                obj.PersonId = s.PersonId;

                viewList.Add(obj);
                obj.SaveChanges();
            }

            return View(viewList);
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        public ActionResult Create(ContactViewModel obj)
        {
            try
            {
                Contact s = new Contact();
                s.ContactId = obj.ContactId;
                s.ContactNumber = obj.ContactNumber;
                s.Type = obj.Type;
                s.PersonId = obj.PersonId;

                PhoneBookDbEntities4 db = new PhoneBookDbEntities4();
                db.Contacts.Add(s);
                db.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contact/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contact/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
