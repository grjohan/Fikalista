using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IMember
    {
        int id { get; set; }
        DateTime NextFika { get; set; }
        string Name { get; set; }
        string Email { get; set; }
    }
}
