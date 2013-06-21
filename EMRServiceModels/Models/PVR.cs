using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRServiceModels.Models
{
    public class PVR
    {

        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string Id { get; set; }
        public string patientId { get; set; }
        public string Date { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string resonForVist { get; set; }
        public string[] Symptoms { get; set; }
        public int BloodPressure { get; set; }
        public double Temperature { get; set; }
        public int HeartRate { get; set; }
        public string CourseOfTreatment { get; set; }
        public string notes { get; set; }

    }
}
