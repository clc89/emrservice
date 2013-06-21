using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRServiceModels.Models
{
    public class Physician
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string Id { get; set; }
        public Name PhysicianName { get; set; }
        public Address PhysicianAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Speciality { get; set; }
    }
}
