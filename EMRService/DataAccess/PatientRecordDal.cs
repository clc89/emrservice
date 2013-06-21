using EMRServiceModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System.Configuration;

namespace EMRService.DataAccess
{
    class PatientRecordDal
    {

        private MongoDatabase database;
        MongoCollection<PatientRecord> patients;
        private MongoClient client;

        public PatientRecordDal()
        {
            client = new MongoClient(ConfigurationManager.ConnectionStrings["Default"].ToString());
            MongoServer server = client.GetServer();
            database = server.GetDatabase("db");

            patients = database.GetCollection<PatientRecord>("patientrecord");
        }

        public PatientRecord getPatientRecord(string id)
        {
            PatientRecord p = database.GetCollection("patientrecord").FindOneByIdAs<PatientRecord>(id);
            return p;
        }

        public IList<PatientRecord> getPatientRecord()
        {
            IList<PatientRecord> list = new List<PatientRecord>();

            patients = database.GetCollection<PatientRecord>("patientrecord");
            foreach (PatientRecord p in patients.FindAll())
            {
                list.Add(p);
            }
            return list;
        }

        public PatientRecord createPatientRecord(PatientRecord p)
        {
            p.Id = Guid.NewGuid().ToString();
            patients.Save<PatientRecord>(p);
            PatientRecord pResult = patients.FindOneByIdAs<PatientRecord>(p.Id);
            return pResult;
        }

        public PatientRecord updatePatientRecord(PatientRecord p)
        {
            patients.Save<PatientRecord>(p);
            PatientRecord pa = patients.FindOneByIdAs<PatientRecord>(p.Id);
            return pa;
        }
    }
}
