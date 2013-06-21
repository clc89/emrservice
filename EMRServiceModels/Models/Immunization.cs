using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRServiceModels.Models
{
    public class Immunization
    {
        public string ImmunizationName { get; set; }
        public string DatePerformed { get; set; }

    }
}
