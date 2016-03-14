using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Member
{
    public interface IMemberService
    {
        IEnumerable<IMember> GetAllListMembers();
        void UpdateListMember(IMember memberToUpdate);
        IMember GetMemberWithNextFika();
        IMember GetMemberWithLastFika();
        DateTime GetNextAvalibleTime();
        IEnumerable<IMember> GetAllMemberWithOldDate();
        void AddMember(string name, string email);
        void GiveAllOldMembersNewTimes();

    }
}
