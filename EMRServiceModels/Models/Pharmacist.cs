using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRServiceModels.Models
{
    public class Pharmacist
    {

        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string Id { get; set; }

        public Name PharmacistName { get; set; }

        public Address PharmacistAddress { get; set; }

        public string PhoneNumber { get; set; }
    }
}
