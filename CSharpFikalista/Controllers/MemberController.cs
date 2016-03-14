using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi.Models;
using Service.Member;
namespace WebApi.Controllers
{
    public class MemberController : Controller
    {
        private IMemberService _memberService; 
        // GET: Member
        public ActionResult Index()
        {
            return View("Member");
        }

        public ActionResult AddMember(FikaMember member) {
            _memberService.AddMember(member.MemberName, member.Email);
            var newModel = new FikaListaModel();
            newModel.Members = _memberService.GetAllListMembers().Select(o => new FikaMember { DateTimeHasFika = o.NextFika, Email = o.Email, MemberName = o.Name, id = o.id }).ToList();
            return View("Home", newModel);
        }
    }
}