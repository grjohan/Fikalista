using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;

namespace Entity
{
    class FikaListaConfiguration
    {
        public static string FikalistaEntititiesConnection
        {
            get
            {
                const string providerName = "System.Data.SqlClient";
                var serverName = @"in2t2shtdq.database.windows.net";
                var databaseName = "fikalista";
                var sqlBuilder = new SqlConnectionStringBuilder
                {
                    DataSource = serverName,
                    InitialCatalog = databaseName,
                    IntegratedSecurity = true,
                    MultipleActiveResultSets = true,
                    PersistSecurityInfo = true,
                    UserID = "",
                    Password = ""
                };
                var providerString = sqlBuilder.ToString();
                var entityBuilder = new EntityConnectionStringBuilder
                {
                    Provider = providerName,
                    ProviderConnectionString = providerString,
                    Metadata = "res://*/fikalistaModel.csdl|res://*/fikalistaModel.ssdl|res://*/fikalistaModel.msl;provider=System.Data.SqlClient"
                };
                return entityBuilder.ToString();
            }
        }
    }
}
