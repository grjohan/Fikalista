using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi.Models;
using Service;

namespace WebApi.Controllers
{
    public class AdminController : Controller
    {
        private Service.Member.IMemberService _memberService;
        private Service.Email.IEmailService _emailService;
        public ActionResult Update()
        {
            _memberService.GiveAllOldMembersNewTimes();
            var firstMember = _memberService.GetMemberWithNextFika();
            _emailService.SendEmailToRecipient(firstMember.Email, "Påminnelse om fika", "Hej, Detta är en påminnelse om att du har fika: " + firstMember.NextFika.ToShortDateString());
            var tempModel = new FikaListaModel();
            tempModel.Members = _memberService.GetAllListMembers().Select(o => new FikaMember { DateTimeHasFika = o.NextFika ,Email =  o.Email,MemberName = o.Name, id = o.id}).ToList();
            return View("Home", tempModel);
        }
    }
}