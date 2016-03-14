using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IMemberRepository
    {
        DateTime GetNextFreeFika(DayOfWeek day);
        IMember GetNextFikaer();
        IMember GetFikaerById(int id);
        IEnumerable<IMember> GetAllFikaers();
        IMember GetLastFikaer();
    }
}
