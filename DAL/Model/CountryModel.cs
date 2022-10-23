using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class CountryModel
    {
        public List<Country> Get()
        {
            using (coronaEntities db = new coronaEntities())
            {
                return db.Countries.ToList();
            }
        }
        public Country GetCountryBycountryId(int countryId)
        {
            using (coronaEntities db = new coronaEntities())
            {
                return db.Countries.FirstOrDefault(x => x.Id == countryId);
            }
        }
        public Country Post(Country country)
        {
            using (coronaEntities db = new coronaEntities())
            {
                country = db.Countries.Add(country);
                db.SaveChanges();
                return country;
            }
        }
        public Country Put(Country country)
        {
            using (coronaEntities db = new coronaEntities())
            {
                Country newCountry = db.Countries.FirstOrDefault(x => x.Id == country.Id);
                newCountry.Name = country.Name;
                db.SaveChanges();
                return country;
            }
        }
        public bool Delete(int id)
        {
            using (coronaEntities db = new coronaEntities())
            {
                Country newCountry = db.Countries.Remove(db.Countries.FirstOrDefault(x => x.Id == id));
                db.SaveChanges();
                return true;
            }
        }
    }
}
