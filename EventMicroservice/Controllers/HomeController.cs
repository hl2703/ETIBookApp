using EventMicroservice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EventMicroservice.DAL;


namespace EventMicroservice.Controllers
{
    public class HomeController : Controller
    {
        private EventDAL eventContext = new EventDAL();



        public ActionResult Index()
        {
            List<BookEvent> eventList = eventContext.GetAllEvents();
            return View(eventList);
        }
        // GET:HomeController/Details/5
        public ActionResult Details(int id)
        {

            BookEvent e = eventContext.GetDetails(id);

            return View(e);
        }


    }
}
