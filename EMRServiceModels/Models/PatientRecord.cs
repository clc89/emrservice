using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRServiceModels.Models
{
    public class PatientRecord
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string Id { get; set; }
        public Name PatientName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string DaytimeNumber { get; set; }
        public string EveningNumber { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
        public string MaritalStatus { get; set; }
        public string SexualOrientation { get; set; }
        public string Ethnicity { get; set; }
        public Address PhysicalAddress { get; set; }
        public Address BillingAddress { get; set; }
        public Contact EmergencyContact { get; set; }
        public string FamilyPhysician { get; set; }
        public Immunization[] Immunizations { get; set; }
        public bool PastTabaccoUse { get; set; }
        public bool CurrentTabaccoUse { get; set; }
        public string[] DrugHistory { get; set; }
        public string[] Allergies { get; set; }
        public string[] FamilyHistory { get; set; }
        public string[] ListOfPhysicians { get; set; }
        public Contact LegalGuardian { get; set; }
        public string[] ListOfProviders { get; set; }
        public Prescription[] ListOfPrescriptions { get; set; }

    }
}
