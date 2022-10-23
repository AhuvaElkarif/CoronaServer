using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class VaccinationModel
    {
        public List<Vaccination> Get()
        {
            using (coronaEntities db = new coronaEntities())
            {
                return db.Vaccinations.Include("VaccineManufacturer").Include("VaccineManufacturer.Country").ToList();
            }
        }
        public Vaccination GetVaccinationByvaccinationId(int vaccinationId)
        {
            using (coronaEntities db = new coronaEntities())
            {
                return db.Vaccinations.FirstOrDefault(x => x.Id == vaccinationId);
            }
        }
        public List<Vaccination> GetVaccinationByMemberId(int memberId)
        {
            using (coronaEntities db = new coronaEntities())
            {
                return db.Vaccinations.Where(x => x.MemberId == memberId).ToList();
            }
        }
        public Vaccination Post(Vaccination vaccination)
        {
            using (coronaEntities db = new coronaEntities())
            {
                vaccination = db.Vaccinations.Add(vaccination);
                db.SaveChanges();
                return vaccination;
            }
        }
        public Vaccination Put(Vaccination vaccination)
        {
            using (coronaEntities db = new coronaEntities())
            {
                Vaccination newVaccination = db.Vaccinations.FirstOrDefault(x => x.Id == vaccination.Id);
                newVaccination.Date = vaccination.Date;
                newVaccination.MemberId = vaccination.MemberId;
                newVaccination.VaccinationId = vaccination.VaccinationId;
                newVaccination.NumVaccination = vaccination.NumVaccination;
                db.SaveChanges();
                return vaccination;
            }
        }
        public bool Delete(int id)
        {
            using (coronaEntities db = new coronaEntities())
            {
                Vaccination newVaccination = db.Vaccinations.Remove(db.Vaccinations.FirstOrDefault(x => x.Id == id));
                db.SaveChanges();
                return true;
            }
        }
    }
}