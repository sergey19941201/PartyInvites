using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            /*
            string noob = "noob";
            ViewBag.noob = noob;
            */

            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            ViewBag.Idiot = "Idiot";
            ViewBag.Asshole = "Asshole";
            ViewBag.Shit = "Shit";
            return View();
        }

        //Method for get-requests
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        //Method for post-request
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {     // TODO: Email response to the party organizer
                return View("Thanks", guestResponse);
            }
            else
            {     // there is a validation error
                return View();
            }
        }
    }
}