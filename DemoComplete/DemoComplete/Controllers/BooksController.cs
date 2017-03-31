using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoComplete.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View(Repositories.BooksRepository.GetBooks());
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}