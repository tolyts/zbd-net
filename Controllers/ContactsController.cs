using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using zbd_net.Models;
using Microsoft.AspNetCore.Mvc;
using zbd_net.helpers;

namespace zbd_net.Controllers {
    [Route("contacts")]
    public class ContactsController : Controller
    {
        private readonly ContactContext _context;
        public ContactsController(ContactContext context)
        {
            _context = context;
        }
        public IActionResult Index() {
            ViewData["Message"] = "Your application description page.";
            var stories = _context.contact.Select(c=>new {c.firstname, c.lastname, c.email}.ToExpando()).ToList();
            return View(stories);
        }
        
        [HttpGet("json")]
        public IEnumerable<Contact>  Get() {
            var list = _context.contact.ToList();
            return list;
        }

        

        // GET: api/authors
        [HttpGet("1")]
        public IEnumerable<Contact> Get1()
        {

            var list = _context.contact.ToList();
            return list;
        }

        // GET api/authors/5
        // [HttpGet("{id}")]
        // public Contact Get(int id)
        // {
        //     return _context.Contacts.FirstOrDefault(x => x.Id == id);
        // }

        // POST api/authors
        // [HttpPost]
        // public IActionResult Post([FromBody]Author value)
        // {
        //     _context.Authors.Add(value);
        //     _context.SaveChanges();
        //     return StatusCode(201, value);
        // }
    }
}