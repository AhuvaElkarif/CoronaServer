using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class CoronaPatientModel
    {
        public List<CoronaPatient> Get()
        {
            using (coronaEntities db = new coronaEntities())
            {
                return db.CoronaPatients.ToList();
            }
        }
        public List<CoronaPatientsCount> GetNumberOfCoronaPatientsInLastMonth()
        {
            using (coronaEntities db = new coronaEntities())
            {
                DateTime now = DateTime.Now;
                return db.CoronaPatients.Where(x => x.StartDate.Month == now.Month - 1 && x.StartDate.Year == now.Year)
                .GroupBy(x => x.StartDate.Day).Select(x => new CoronaPatientsCount() { x = x.Key, y = x.Count() })
                .ToList();

            }
        }


        public CoronaPatient GetCoronaPatientByMemberId(int id)
        {
            using (coronaEntities db = new coronaEntities())
            {
                return db.CoronaPatients.FirstOrDefault(x => x.MemberId == id);
            }
        }
        public CoronaPatient Post(CoronaPatient coronaPatient)
        {
            using (coronaEntities db = new coronaEntities())
            {
                coronaPatient = db.CoronaPatients.Add(coronaPatient);
                db.SaveChanges();
                return coronaPatient;
            }
        }
        public CoronaPatient Put(CoronaPatient coronaPatient)
        {
            using (coronaEntities db = new coronaEntities())
            {
                CoronaPatient newCoronaPatient = db.CoronaPatients.FirstOrDefault(x => x.Id == coronaPatient.Id);
                newCoronaPatient.StartDate = coronaPatient.StartDate;
                newCoronaPatient.EndDate = coronaPatient.EndDate;
                newCoronaPatient.MemberId = coronaPatient.MemberId;
                db.SaveChanges();
                return coronaPatient;
            }
        }
        public bool Delete(int id)
        {
            using (coronaEntities db = new coronaEntities())
            {
                CoronaPatient newC = db.CoronaPatients.Remove(db.CoronaPatients.FirstOrDefault(x => x.Id == id));
                db.SaveChanges();
                return true;
            }
        }
    }
}