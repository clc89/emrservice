using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRServiceModels.Models
{
    public class Prescription
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string PrescriptionId { get; set; }
        public string PatientId { get; set; }
        public string Medication { get; set; }
        public string StartDate { get; set; }
        public string PhysicianId { get; set; }
        public int Dose { get; set; }
        public int Quantity{ get; set; }
        public bool Refills { get; set; }
        public bool GenericAllowed { get; set; }
        public PrescriptionFilled[] DatesFilled { get; set; }
        public string notes { get; set; }
    }
}
