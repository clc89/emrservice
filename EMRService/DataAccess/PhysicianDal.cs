using MongoDB.Bson;
using MongoDB.Driver;
using EMRServiceModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MongoDB.Driver.Builders;

namespace EMRService.DataAccess
{
    class PhysicianDal
    {
        private MongoDatabase database;
        MongoCollection<Physician> physicians;
        private MongoClient client;

        public PhysicianDal()
        {
            client = new MongoClient(ConfigurationManager.ConnectionStrings["Default"].ToString());
            MongoServer server = client.GetServer();
            database = server.GetDatabase("db");

            physicians = database.GetCollection<Physician>("physician");
        }
        public Physician getPhysician(string id)
        {
            return physicians.FindOneByIdAs<Physician>(id);
        }

        public IList<Physician> getPhysician()
        {
            IList<Physician> list = new List<Physician>();

            physicians = database.GetCollection<Physician>("physician");
            foreach (Physician i in physicians.FindAll())
            {
                list.Add(i);
            }
            return list;
        }

        public Physician createPhysician(Physician p)
        {
            p.Id = Guid.NewGuid().ToString();
            physicians.Save<Physician>(p);
            Physician ph = physicians.FindOneByIdAs<Physician>(p.Id);
            return ph;
        }

        public Physician updatePhysician(Physician p)
        {
            physicians.Save<Physician>(p);
            Physician ph = physicians.FindOneByIdAs<Physician>(p.Id);
            return ph;
        } 
    }
}
