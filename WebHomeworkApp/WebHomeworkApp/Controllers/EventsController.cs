using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHomeworkApp.Models;

namespace WebHomeworkApp.Controllers
{
    public class EventsController : Controller
    {
        public static List<Models.Events> events = new List<Models.Events>();

        // GET: User
        public ActionResult Index()
        {
            return View(events);
        }

        public ActionResult Details()
        {
            Models.Events myEvent = new Models.Events() { Title = "Untold", Details = "Concert", Location = "Cluj", DateAndTime = new DateTime(2017, 07, 13) };
            return View(myEvent);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Events myEvent)
        {
            if (myEvent.Title == null || myEvent.Title == String.Empty)
            {
                //var responseMessage = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
                Response.StatusCode.Equals(404);
                return View();
            }
            else
            {
                events.Add(myEvent);
                return RedirectToAction("Details");
            }
        }
    }
}