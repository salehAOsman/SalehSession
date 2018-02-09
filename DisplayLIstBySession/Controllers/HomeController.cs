using DisplayLIstBySession.Models;//to pass  "Book" collection from Class as input to work with it
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DisplayLIstBySession.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()//beging method
        {
            var peopleCollecion = new List<Person>();                                //reference for list type generic or object                                                 
            if (Session["PeopleCollecion"] != null)
            {
                peopleCollecion = (List<Person>)Session["PeopleCollecion"];           //casting session as list type the assign it to object of list same type  
            }
            return View(peopleCollecion);
        }

        [HttpGet]
        public ActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPerson(Person newBook)                                    //We need to sumit form from view "AddBook"
        {
            List<Person> peopleCollecion = new List<Person>();                           //we need object to deal with this class and this to be as list of book//reference for list type generic or object
            if (Session["PeopleCollecion"] !=null)
            {
                peopleCollecion = (List<Person>)Session["PeopleCollecion"];
            }
            peopleCollecion.Add(newBook);                                                //I am going to persist that information to the session//We call this session "BooksCollecion" 
            Session["PeopleCollecion"] = peopleCollecion;                                //if booksCollection is not equal to null then I want the current books so books collection dot add then                                  

            if (ModelState.IsValid)                                                      // then I update the session I is going to equal the current collection of books so 
            {
            return RedirectToAction("Index");                                            // here istead of returning a view we will return by Redirection to action "index" 
            }
            else
            {
                return View();
            }
        }
    }
}