using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    
    public class HomeController : Controller
    {
        public PersonContext db = new PersonContext();

        public ViewResult Index( string searchString)
        {
         
            var users = from s in db.People select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.LastName.Contains(searchString) || s.MiddleName.Contains(searchString) || s.Name.Contains(searchString));
            }
          return View(users.ToList());
        }

        [HttpGet]
        public ActionResult CreatePerson()
        {
           ViewBag.Title = "User";
           ViewBag.Message = "Add";
           ViewBag.verb = "ADD";
           ViewBag.able = true;
           return View("Form");
        }

        [HttpPost]
        public ActionResult CreatePerson(Person person)
        {
            ViewBag.Title = "User";
            ViewBag.Message = "Add";
            ViewBag.verb = "ADD";
            ViewBag.able = true;
            db.People.Add(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditPerson(int id)
        {
            ViewBag.Title = "User";
            ViewBag.Message = "Edit";
            ViewBag.verb = "UPDATE";
            ViewBag.able = false;
            Person person = db.People.Find(id);
            return View("Form", person);
        }

        [HttpPost]
        public ActionResult EditPerson(Person person)
        {
            ViewBag.Title = "User";
            ViewBag.Message = "Edit";
            ViewBag.verb = "UPDATE";
            ViewBag.able = false;
            Person temp = db.People.Find(person.Id);
            temp.Address = person.Address;
            temp.Age = person.Age;
            temp.Id = person.Id;
            temp.LastName = person.LastName;
            temp.MiddleName = person.MiddleName;
            temp.Name= person.Name;
            temp.PhoneNumber = person.PhoneNumber;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeletePerson(int id)
        {
            ViewBag.Title = "User";
            ViewBag.Message = "Delete";
            ViewBag.verb = "DELETE";
            ViewBag.able = true;
            Person person = db.People.Find(id);
            if(person==null)
            {
                return HttpNotFound();
            }
            return View("Form", person);
        }

        [HttpPost, ActionName("DeletePerson")]
        public ActionResult Delete(int id)
        {
            ViewBag.Title = "User";
            ViewBag.Message = "Delete";
            ViewBag.verb = "DELETE";
            ViewBag.able = true;
            Person temp = db.People.Find(id);
            if (temp == null)
            {
                return HttpNotFound();
            }
            db.People.Remove(temp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}