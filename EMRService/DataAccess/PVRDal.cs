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
    class PVRDal
    {

        private MongoDatabase database;
        MongoCollection<PVR> pvr;
        MongoCollection<PatientRecord> patientrecords;
        private MongoClient client;

        public PVRDal()
        {
            client = new MongoClient(ConfigurationManager.ConnectionStrings["Default"].ToString());
            MongoServer server = client.GetServer();
            database = server.GetDatabase("db");

            pvr = database.GetCollection<PVR>("pvr");
            patientrecords = database.GetCollection<PatientRecord>("patientrecord");
        }


        public IList<PVR> getPVR(string id)
        {
            IList<PVR> list = new List<PVR>();

            pvr = database.GetCollection<PVR>("pvr");
            foreach (PVR i in pvr.Find(Query.EQ("patientId", id)))
            {
                list.Add(i);
            }
            return list;
        }

        public PVR createPVR(PVR i, string id)
        {
            i.Id = Guid.NewGuid().ToString();
            i.patientId = id;
            var count = patientrecords.FindAs<PatientRecord>(Query.EQ("_id", id)).Count();
            if (count == 0)
                return null;
            pvr.Save<PVR>(i);
            PVR iResult = pvr.FindOneByIdAs<PVR>(i.Id);
            return iResult;
        }

        public PVR updatePVR(PVR i)
        {
            pvr.Save(i);
            PVR iResult = pvr.FindOneByIdAs<PVR>(i.Id);
            return iResult;
        }
    }

}
