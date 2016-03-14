using System;

namespace DataLayer
{
     class AdministratorRepository : IAdministratorRepository
    {
        public void AddNewAdministrator(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool AuthenticateAsAdministrator(string username, string password)
        {
            using(var ctx = new Entity.fikalistaEntities(Entity.FikaListaConfiguration.FikalistaEntititiesConnection))
            {

            }
            return true;
        }
    }
}
