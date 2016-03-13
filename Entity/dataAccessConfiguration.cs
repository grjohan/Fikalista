using System.Data.Entity;


namespace Entity
{
    public class dataAccessConfiguration : DbConfiguration
    {
        public dataAccessConfiguration()
        {
            SetProviderServices("System.Data.SqlClient", System.Data.Entity.SqlServer.SqlProviderServices.Instance);
        }
    }
}
