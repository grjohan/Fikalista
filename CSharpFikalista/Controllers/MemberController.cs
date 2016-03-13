using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSharpFikalista.Models;

namespace CSharpFikalista.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            return View("Member");
        }

        public ActionResult AddMember(FikaListaMember member) {
            var fikalistmodel = new FikaListaModel();
            fikalistmodel.AddMember(member);
            var newModel = new FikaListaModel();
            return View("Home", newModel);
        }
    }
}