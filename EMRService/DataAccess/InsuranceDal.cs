using MongoDB.Bson;
using MongoDB.Driver;
using EMRServiceModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EMRService.DataAccess
{
    class InsuranceDal
    {

        private MongoDatabase database;
        MongoCollection<Insurance> insurance;
        private MongoClient client;

        public InsuranceDal()
        {
            client = new MongoClient(ConfigurationManager.ConnectionStrings["Default"].ToString());
            MongoServer server = client.GetServer();
            database = server.GetDatabase("db");

            insurance = database.GetCollection<Insurance>("insurance");
        }

        public Insurance getInsurance(string id)
        {
            return insurance.FindOneByIdAs<Insurance>(id);
        }

        public IList<Insurance> getInsurance()
        {
            IList<Insurance> list = new List<Insurance>();

            insurance = database.GetCollection<Insurance>("insurance");
            foreach (Insurance i in insurance.FindAll())
            {
                list.Add(i);
            }
            return list;
        }

        public Insurance createInsurance(Insurance i)
        {
            i.Id = Guid.NewGuid().ToString();
            insurance.Save<Insurance>(i);
            Insurance iResult = insurance.FindOneByIdAs<Insurance>(i.Id);
            return iResult;
        }

        public Insurance updateInsurance(Insurance i)
        {
            insurance.Save(i);
            Insurance iResult = insurance.FindOneByIdAs<Insurance>(i.Id);
            return iResult;
        }
    }
    
}
