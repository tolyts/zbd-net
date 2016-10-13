using System;
using System.Collections.Generic;
using System.Linq;
using zbd_net.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


using System.ComponentModel;


namespace zbd_net.Controllers
{
    public class HomeController : Controller
    {
        private readonly StoryContext _storyContext;
        private readonly ContactContext _contactContext;
        public HomeController(StoryContext storyContext, ContactContext contactContext)
        {
            _storyContext = storyContext;
            _contactContext = contactContext;
        } 
        public IActionResult Index()
        {
            IEnumerable<Story__c> story__c = _storyContext.story__c.Take(5).ToList();
            ViewData["Stories"] = story__c;
            ViewData["Contacts"] = _contactContext.contact.Take(5).ToList();
            //return View(story__c);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
