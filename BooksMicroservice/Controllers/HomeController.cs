using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using BrowseBook.DAL;
using BrowseBook.Models;
using System.Data.SqlClient;

namespace BrowseBook.Controllers
{
    public class HomeController : Controller
    {
        private BookDAL bookContext = new BookDAL();



        public ActionResult Index()
        {
            List<Book> bookList = bookContext.GetAllBooks();
            return View(bookList);
        }
        // GET:HomeController/Details/5
        public ActionResult Details(int id)
        {

            Book book = bookContext.GetDetails(id);

            return View(book);
        }


    }
}
