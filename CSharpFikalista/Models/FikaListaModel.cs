using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.ComponentModel;
namespace CSharpFikalista.Models
{
    public class FikaListaModel
    {
        public List<FikaListaMember> members { get; private set; }
        public FikaListaModel()
        {
            using (var ctx = new Entity.fikalistaEntities())
            {
                var dbMembers = ctx.tblFikaMembers.OrderBy(dbmember => dbmember.NextFika).ToList();
                members = dbMembers.Select(dbMember => new FikaListaMember(dbMember)).ToList();
            }
        }

        public void AddMember(FikaListaMember member)
        {
            using (var ctx = new Entity.fikalistaEntities())
            {
                var dbMember = new Entity.tblFikaMembers { Email = member.Email, Name = member.MemberName };
                var lastDate = FikaListaMember.GetMemberWithLastFika().AddDays(7);
                dbMember.NextFika = lastDate;
                ctx.tblFikaMembers.Add(dbMember);
                ctx.SaveChanges();
            }
        }
    }

    public class FikaListaMember{
        private int id { get; set; }
        [DisplayName("Namn")]
        public string MemberName{get;set;}
        public string DateTimeHasFika {get;set;}
        public string Email { get; set; }

        public FikaListaMember() { }

        public FikaListaMember(Entity.tblFikaMembers member) {
            DateTimeHasFika = member.NextFika.Value.ToString(CultureInfo.GetCultureInfo(("sv-SE")).DateTimeFormat.ShortDatePattern);
            Email = member.Email;
            MemberName = member.Name;
            id = member.fikapersonId;
        }



        public void MoveToBackOfList(){
            using(var ctx = new Entity.fikalistaEntities()){
                var lastWeek = ctx.tblFikaMembers.OrderByDescending(member => member.NextFika).First();
                var memberToUpdate = ctx.tblFikaMembers.First(member => member.fikapersonId == id);
                memberToUpdate.NextFika = lastWeek.NextFika.Value.AddDays(7);
                src.eMailHandler.sendEmailAboutNextFika(memberToUpdate.Email, memberToUpdate.NextFika.Value.ToString(CultureInfo.GetCultureInfo(("sv-SE")).DateTimeFormat.ShortDatePattern));
                ctx.SaveChanges();
            }
        }

        public static DateTime GetMemberWithLastFika() {
            using (var ctx = new Entity.fikalistaEntities())
            {
                var lastWeek = ctx.tblFikaMembers.OrderByDescending(member => member.NextFika).First().NextFika;
                return lastWeek.Value;
            }
        }
    }
}