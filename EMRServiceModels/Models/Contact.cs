using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRServiceModels.Models
{
    public class Contact
    {
        public Name ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public Address ContactAddress { get; set; }
        public string Relationship { get; set; }

    }
}
