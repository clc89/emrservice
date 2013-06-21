using System.ServiceModel;
using EMRServiceModels.Models;
using System.ServiceModel.Web;
using System.Collections.Generic;

namespace EMRService
{
    [ServiceContract]
    public interface IPatientService
    {
        // Patient Record Methods
        [OperationContract (Name="getSinglePatient")]
        [WebInvoke(Method = "GET", UriTemplate = "/patientrecord/{id}", ResponseFormat = WebMessageFormat.Json)]
        PatientRecord GetPatientRecord(string id);

        // Patient Record Methods
        [OperationContract(Name="GetAllPatients")]
        [WebInvoke(Method = "GET", UriTemplate = "/patientrecord", ResponseFormat = WebMessageFormat.Json)]
        IList<PatientRecord> GetPatientRecord();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/patientrecord", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        PatientRecord CreatePatientRecord(PatientRecord p);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/patientrecord", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        PatientRecord UpdatePatientRecord(PatientRecord p);


        // Insurance Methods
        [OperationContract (Name= "getSingleInsurance")]
        [WebInvoke(Method = "GET", UriTemplate = "/insurance/{id}", ResponseFormat = WebMessageFormat.Json)]
        Insurance GetInsurance(string id);

        [OperationContract (Name = "getAllInsurance")]
        [WebInvoke(Method = "GET", UriTemplate = "/insurance", ResponseFormat = WebMessageFormat.Json)]
        IList<Insurance> GetInsurance();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/insurance", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Insurance CreateInsurance(Insurance i);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/insurance", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Insurance UpdateInsurance(Insurance i);


        // Phamacist Methods
        [OperationContract(Name = "getSinglePharmacist")]
        [WebInvoke(Method = "GET", UriTemplate = "/pharmacist/{id}", ResponseFormat = WebMessageFormat.Json)]
        Pharmacist GetPharmacist(string id);

        [OperationContract (Name = "getAllPharmacist")]
        [WebInvoke(Method = "GET", UriTemplate = "/pharmacist", ResponseFormat = WebMessageFormat.Json)]
        IList<Pharmacist> GetPharmacist();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/pharmacist", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Pharmacist CreatePharmacist(Pharmacist p);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/pharmacist", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Pharmacist UpdatePharmacist(Pharmacist p);

        // Physician Methods
        [OperationContract (Name="getSinglePhysician")]
        [WebInvoke(Method = "GET", UriTemplate = "/physician/{id}", ResponseFormat = WebMessageFormat.Json)]
        Physician GetPhysician(string id);

        [OperationContract(Name = "getAllPhysician")]
        [WebInvoke(Method = "GET", UriTemplate = "/physician", ResponseFormat = WebMessageFormat.Json)]
        IList<Physician> GetPhysician();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/physician", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Physician CreatePhysician(Physician p);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/physician", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Physician UpdatePhysician(Physician p);

        //PVR Methods
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "patientrecord/{id}/pvr", ResponseFormat = WebMessageFormat.Json)]
        IList<PVR> GetPVR(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "patientrecord/{id}/pvr", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        PVR CreatePVR(PVR p, string id);


        //Prescription Methods
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/prescription/{id}", ResponseFormat = WebMessageFormat.Json)]
        Prescription GetPrescription(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/prescription", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Prescription CreatePrescription(Prescription p);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/prescription", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Prescription UpdatePrescription(Prescription p);

        //Search Methods
        //        [OperationContract]
        //        [WebInvoke(Method = "GET", UriTemplate = "/anonymouspatientdata?{id}", ResponseFormat = WebMessageFormat.Json)]
        //        PatientRecord GetPatientRecord(string id);
    }
}