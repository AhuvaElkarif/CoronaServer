using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class MemberModel
    {
        public List<Member> Get()
        {
            using (coronaEntities db = new coronaEntities())
            {
                return db.Members.Include("City").Where(x =>  x.IsActive == true).ToList().ToList();
            }
        }
        public Member GetMemberByMemberId(int MemberId)
        {
            using (coronaEntities db = new coronaEntities())
            {
                return db.Members.Include("City").FirstOrDefault(x => x.Id == MemberId);
            }
        }
        public bool IsExist(string id)
        {
            using (coronaEntities db = new coronaEntities())
            {
                return db.Members.Any(x => x.IdNumber == id);
            }
        }
        public Member Post(Member member)
        {
            using (coronaEntities db = new coronaEntities())
            {
                if (IsExist(member.IdNumber))
                    return null;
                City c = db.Cities.FirstOrDefault(x => x.Id == member.CityId);
                member.City = c;
                member = db.Members.Add(member);
                db.SaveChanges();
                return member;
            }
        }
        public Member Put(Member Member)
        {
            using (coronaEntities db = new coronaEntities())
            {

                Member newMember = db.Members.Include("City").FirstOrDefault(x => x.Id == Member.Id);
                newMember.Street = Member.Street;
                newMember.Vaccinations = Member.Vaccinations;
                newMember.CityId = Member.CityId;
                newMember.IdNumber = Member.IdNumber;
                newMember.BirthDate = Member.BirthDate;
                newMember.HouseNumber = Member.HouseNumber;
                newMember.FirstName = Member.FirstName;
                newMember.LastName = Member.LastName;
                newMember.IsActive = Member.IsActive;
                db.SaveChanges();
                return Member;
            }
        }
        public Member ChangeMemberStatus(int id)
        {
            using (coronaEntities db = new coronaEntities())
            {
                Member m = db.Members.Include("City").FirstOrDefault(x => x.Id == id);
                m.IsActive = !m.IsActive;
                db.SaveChanges();
                return m;
            }
        }
        public bool Delete(int id)
        {
            using (coronaEntities db = new coronaEntities())
            {
                Member newMember = db.Members.Remove(db.Members.FirstOrDefault(x => x.Id == id));
                db.SaveChanges();
                return true;
            }
        }
    }
}
