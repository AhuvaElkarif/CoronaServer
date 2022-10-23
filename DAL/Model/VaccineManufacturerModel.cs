using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class VaccineManufacturerModel
    {
        public List<VaccineManufacturer> Get()
        {
            using (coronaEntities db = new coronaEntities())
            {
                return db.VaccineManufacturers.ToList();
            }
        }
        public VaccineManufacturer GetVaccineManufacturerByid(int id)
        {
            using (coronaEntities db = new coronaEntities())
            {
                return db.VaccineManufacturers.FirstOrDefault(x => x.Id == id);
            }
        }
        public VaccineManufacturer Post(VaccineManufacturer VaccineManufacturer)
        {
            using (coronaEntities db = new coronaEntities())
            {
                VaccineManufacturer = db.VaccineManufacturers.Add(VaccineManufacturer);
                db.SaveChanges();
                return VaccineManufacturer;
            }
        }
        public VaccineManufacturer Put(VaccineManufacturer VaccineManufacturer)
        {
            using (coronaEntities db = new coronaEntities())
            {
                VaccineManufacturer newVaccineManufacturer = db.VaccineManufacturers.FirstOrDefault(x => x.Id == VaccineManufacturer.Id);
                newVaccineManufacturer.Name = VaccineManufacturer.Name;
                db.SaveChanges();
                return VaccineManufacturer;
            }
        }
        public bool Delete(int id)
        {
            using (coronaEntities db = new coronaEntities())
            {
                VaccineManufacturer newV = db.VaccineManufacturers.Remove(db.VaccineManufacturers.FirstOrDefault(x => x.Id == id));
                db.SaveChanges();
                return true;
            }
        }
    }
}