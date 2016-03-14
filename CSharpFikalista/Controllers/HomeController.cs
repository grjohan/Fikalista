using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi.Models;
using Service.Member;
namespace WebApi.Controllers
{
    public class HomeController : Controller
    {
        private IMemberService _memberService;
        public ActionResult Index()
        {
            var model = new FikaListaModel();
            model.Members = _memberService.GetAllListMembers().Select(o => new FikaMember { DateTimeHasFika = o.NextFika, Email = o.Email, MemberName = o.Name, id = o.id }).ToList();
            return View("Home", model);
        }

    }
}