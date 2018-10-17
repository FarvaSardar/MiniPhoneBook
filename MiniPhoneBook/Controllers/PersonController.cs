using MiniPhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MiniPhoneBook.Controllers
{
    public class PersonController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            PhoneBookDbEntities4 db = new PhoneBookDbEntities4();
            List<Person> list = db.People.ToList();
            List<PersonViewModel> viewList = new List<PersonViewModel>();
            foreach (Person s in list)
            {
                PersonViewModel obj = new PersonViewModel();
                obj.PersonId = s.PersonId;
                obj.FirstName = s.FirstName;
                obj.MiddleName = s.MiddleName;
                obj.LastName = s.LastName;
                obj.DateOfBirth = s.DateOfBirth;
                obj.AddedOn = s.AddedOn;
                obj.AddedBy = s.AddedBy;
                obj.HomeAddress = s.HomeAddress;
                obj.HomeCity = s.HomeCity;
                obj.FaceBookAccountId = s.FaceBookAccountId;
                obj.LinkedInId = s.LinkedInId;
                obj.UpdateOn = s.UpdateOn;
                obj.TwitterId = s.TwitterId;
                obj.EmailId = s.EmailId;
            
                viewList.Add(obj);
                obj.SaveChanges();

            }

            return View(viewList);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(PersonViewModel obj)
        {
            try
            {
                Person s = new Person();
                s.PersonId = obj.PersonId;
                s.FirstName = obj.FirstName;
                s.MiddleName = obj.MiddleName;
                s.LastName = obj.LastName;
                s.DateOfBirth = obj.DateOfBirth;
                s.AddedOn = obj.AddedOn;
                s.AddedBy = obj.AddedBy;
                s.HomeAddress = obj.HomeAddress;
                s.HomeCity = obj.HomeCity;
                s.FaceBookAccountId = obj.FaceBookAccountId;
                s.LinkedInId = obj.LinkedInId;
                s.UpdateOn = obj.UpdateOn;
                s.TwitterId = obj.TwitterId;
                s.EmailId = obj.EmailId;

                PhoneBookDbEntities4 db = new PhoneBookDbEntities4();
                db.People.Add(s);
                db.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
