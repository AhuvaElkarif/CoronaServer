using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class CityModel
    {
        public List<City> Get()
        {
            using (coronaEntities db = new coronaEntities())
            {
                return db.Cities.ToList();
            }
        }
        public City GetCityByCityId(int cityId)
        {
            using (coronaEntities db = new coronaEntities())
            {
                return db.Cities.FirstOrDefault(x => x.Id == cityId);
            }
        }
        public City Post(City city)
        {
            using (coronaEntities db = new coronaEntities())
            {
                city = db.Cities.Add(city);
                db.SaveChanges();
                return city;
            }
        }
        public City Put(City city)
        {
            using (coronaEntities db = new coronaEntities())
            {
                City newCity = db.Cities.FirstOrDefault(x => x.Id == city.Id);
                newCity.Name = city.Name;
                db.SaveChanges();
                return city;
            }
        }
        public bool Delete(int id)
        {
            using (coronaEntities db = new coronaEntities())
            {
                City newCity = db.Cities.Remove(db.Cities.FirstOrDefault(x => x.Id == id));
                db.SaveChanges();
                return true;
            }
        }
    }
}
