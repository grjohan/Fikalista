using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Entity
{
    [DbConfigurationType(typeof(dataAccessConfiguration))]
    public partial class fikalistaEntities
    {
        public fikalistaEntities(string connectionString) : base(connectionString) { }
    }
}
