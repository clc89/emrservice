using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EMRServiceModels.Models
{
    public class PrescriptionFilled
    {

        public DateTime datefilled { get; set; }
        public string PharmacistId { get; set; }
    }
}
