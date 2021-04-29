using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NightclubEventsWebsite.Models;

namespace NightclubEventsWebsite.Controllers
{
    public class CMSController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CMSController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Cms()
        {
            List<Event> events = _context.Events.ToList();
            return View(events);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GotoCms()
        {
            List<Event> events = _context.Events.ToList();
            return View("Cms", events);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddEvent(
            string addEventTitle,
            string addEventClubname,
            string addEventDJName,
            string addEventDate,
            string addEventStartTime,
            string addEventEndTime)
        {
            
            var newStartTime = DateTime.ParseExact(addEventStartTime, "H:mm", null, System.Globalization.DateTimeStyles.None);
            var newEndTime = DateTime.ParseExact(addEventEndTime, "H:mm", null, System.Globalization.DateTimeStyles.None);

            Event newEvent = new Event
            {
                EventTitle = addEventTitle,
                ClubName = addEventClubname,
                DJName = addEventDJName,
                EventDate = DateTime.Parse(addEventDate),
                StartTime = newStartTime,
                EndTime = newEndTime
            };

            _context.Add(newEvent);
            _context.SaveChanges();
            return RedirectToAction(nameof(Cms));
        }

        public IActionResult RemoveEvent(string deleteEventTitle)
        {
            var eventId = from e in _context.Events where e.EventTitle == deleteEventTitle select e;

            Event ev = eventId.First();

            Debug.WriteLine("Delete event: " + ev.EventID + " - " + ev.EventTitle);

            _context.Remove(ev);
            _context.SaveChanges();

            return RedirectToAction(nameof(Cms));
        }
    }
}
