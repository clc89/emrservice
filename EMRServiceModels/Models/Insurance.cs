using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRServiceModels.Models
{
    public class Insurance
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string PolicyHolderID { get; set; }
        public string GroupPolicy { get; set; }
        public string ContactNumber { get; set; }
        public Address BillingAddress { get; set; }


    }
}
