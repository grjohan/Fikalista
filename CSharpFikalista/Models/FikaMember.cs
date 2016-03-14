using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace WebApi.Models
{
    public class FikaMember
    {
        internal int id { get; set; }
        [DisplayName("Namn")]
        public string MemberName { get; set; }
        public DateTime DateTimeHasFika { get; set; }
        public string Email { get; set; }
    }
}