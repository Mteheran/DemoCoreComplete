using DemoComplete.Models;
using DemoComplete.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DemoComplete.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Books")]
    public class BooksController : Controller
    {
        public IBookService bookservice { get; set; }
        
        public BooksController(IBookService bs)
        {
            bookservice = bs;
        }

        [HttpGet]
        public List<Book> Get()
        {        
            return bookservice.GetBooks();
        }

        [HttpGet]
        [Route("GetJson")]
        public ActionResult GetJson()
        {
            return Json(bookservice.GetBooks());
        }

        [HttpGet]
        [Route("GetView")]
        public ActionResult GetView()
        {
            return   View("Index");
        }
    }
}