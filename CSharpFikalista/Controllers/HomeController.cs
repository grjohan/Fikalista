using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSharpFikalista.Models;

namespace CSharpFikalista.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new FikaListaModel();
            return View("Home", model);
        }

    }
}