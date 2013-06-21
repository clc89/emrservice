using MongoDB.Bson;
using MongoDB.Driver;
using EMRServiceModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Builders;
using System.Configuration;

namespace EMRService.DataAccess
{
    class PharmacistDal
    {
        private MongoDatabase database;
        MongoCollection<Pharmacist> pharmacists;
        private MongoClient client;

        public PharmacistDal()
        {
            client = new MongoClient(ConfigurationManager.ConnectionStrings["Default"].ToString());
            MongoServer server = client.GetServer();
            database = server.GetDatabase("db");

            pharmacists = database.GetCollection<Pharmacist>("pharmacist");
        }

        public Pharmacist getPharmacist(string id)
        {
            Pharmacist p = pharmacists.FindOneByIdAs<Pharmacist>(id);
            return p;
        }

        public IList<Pharmacist> getPharmacist()
        {
            IList<Pharmacist> list = new List<Pharmacist>();

            pharmacists = database.GetCollection<Pharmacist>("pharmacist");
            foreach (Pharmacist p in pharmacists.FindAll())
            {
                list.Add(p);
            }
            return list;
        }

        public Pharmacist getPharmacistByPhone(string phone)
        {
            var query = Query.EQ("PhoneNumber", phone);
            Pharmacist p = pharmacists.FindOneAs<Pharmacist>(query);
            return p;
        }

        public Pharmacist createPharmacist(Pharmacist p)
        {
            p.Id = Guid.NewGuid().ToString();
            pharmacists.Save<Pharmacist>(p);
            Pharmacist pResult = pharmacists.FindOneByIdAs<Pharmacist>(p.Id);
            return pResult;
        }

        public Pharmacist updatePharmacist(Pharmacist p)
        {
            pharmacists.Save(p);

            Pharmacist pResult = pharmacists.FindOneByIdAs<Pharmacist>(p.Id);

            return pResult;
        }
    }
}
