using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IAdministratorRepository
    {
        bool AuthenticateAsAdministrator(string username, string password);
        void AddNewAdministrator(string username, string password);
    }
}
