using System.Collections.Generic;
using LibraryApp.Models;

namespace LibraryApp.Services
{
    public class MemberService
    {
        private readonly List<Member> _members = new List<Member>();

        public void RegisterMember(Member member)
        {
            _members.Add(member);
        }

        public Member GetMember(int memberId)
        {
            return _members.Find(m => m.MemberId == memberId);
        }
    }
}
