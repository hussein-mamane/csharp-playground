using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcCrud.Data;
using MvcCrud.Models;

namespace MvcCrud.Controllers
{
    [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly ILogger<BookController> _logger;
        private readonly ApplicationDbContext _db;

        public BookController(ILogger<BookController> logger,ApplicationDbContext db)
        {
            _db=db;
            _logger = logger;
        }

        public IActionResult BookList()
        {
            List<Book>? books = _db.books.ToList(); 
            return View(books);
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}