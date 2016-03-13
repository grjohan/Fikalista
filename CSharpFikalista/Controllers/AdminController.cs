using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSharpFikalista.Models;

namespace CSharpFikalista.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Update()
        {
            // Create a model
            var tempModel = new FikaListaModel();
            // See if there is someone that has previously had
            var personToMove = tempModel.members.Where(member =>  DateTime.Parse(member.DateTimeHasFika) < DateTime.Now);
            if (personToMove == null)
            {
                return View();
            }
            else
            {
                foreach (var person in personToMove)
                {
                    person.MoveToBackOfList();
                }
            }
            tempModel = new FikaListaModel();
            var firstMember = tempModel.members.First();
            src.eMailHandler.sendEmailAboutNewFika(firstMember.Email, firstMember.DateTimeHasFika);
            return View("Home", tempModel);
        }
    }
}