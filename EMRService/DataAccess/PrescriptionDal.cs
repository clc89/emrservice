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
    class PrescriptionDal
    {
         private MongoDatabase database;
        MongoCollection<Prescription> Prescriptions;
        private MongoClient client;

        public PrescriptionDal()
        {
            client = new MongoClient(ConfigurationManager.ConnectionStrings["Default"].ToString());
            MongoServer server = client.GetServer();
            database = server.GetDatabase("db");

            Prescriptions = database.GetCollection<Prescription>("Prescription");
        }

        public Prescription getPrescription(string id)
        {
            return Prescriptions.FindOneByIdAs<Prescription>(ObjectId.Parse(id));
        }

        public Prescription createPrescription(Prescription p)
        {
            Prescriptions.Save<Prescription>(p);
            return null;
        }

        public Prescription updatePrescription(Prescription p)
        {
            Prescriptions.Save(p);
            return null;
        }
    }
   
}
