using System;
using System.ServiceModel.Web;
using EMRServiceModels.Models;
using EMRService.DataAccess;
using System.Collections.Generic;
using System.Net;

namespace EMRService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class PatientService : IPatientService
    {
        private PhysicianDal physicianDao = new PhysicianDal();
        private PVRDal pvrDao = new PVRDal();
        private PrescriptionDal prescriptionDao = new PrescriptionDal();

        private PatientRecordDal patientRecordDao = new PatientRecordDal();
        private InsuranceDal insuranceDao = new InsuranceDal();
        private PharmacistDal pharmacistDao = new PharmacistDal();
        private TenantDal tenantDao = new TenantDal();

        public PatientRecord GetPatientRecord(string id)
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return patientRecordDao.getPatientRecord(id);
        }

        public IList<PatientRecord> GetPatientRecord()
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return patientRecordDao.getPatientRecord();
        }


        public PatientRecord CreatePatientRecord(PatientRecord p)
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return patientRecordDao.createPatientRecord(p);
        }

        public PatientRecord UpdatePatientRecord(PatientRecord p)
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return patientRecordDao.updatePatientRecord(p);
        }

        public Insurance GetInsurance(string id)
        {

            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return insuranceDao.getInsurance(id);
        }

        public IList<Insurance> GetInsurance()
        {
            Physician p = new Physician();
            physicianDao.createPhysician(p);

            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return insuranceDao.getInsurance();
        }

        public Insurance CreateInsurance(Insurance i)
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return insuranceDao.createInsurance(i);
        }

        public Insurance UpdateInsurance(Insurance i)
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return insuranceDao.updateInsurance(i);
        }

        public Pharmacist GetPharmacist(string id)
        {
            //check for key in header.
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return pharmacistDao.getPharmacist(id);
        }

        public IList<Pharmacist> GetPharmacist()
        {
            //check for key in header.
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
            { 
                return pharmacistDao.getPharmacist();
            }
        }

        public Pharmacist CreatePharmacist(Pharmacist p)
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return pharmacistDao.createPharmacist(p);
        }

        public Pharmacist UpdatePharmacist(Pharmacist p)
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return pharmacistDao.updatePharmacist(p);
        }
        //need to finish the following 

        public Physician GetPhysician(string id)
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return physicianDao.getPhysician(id);
        }

        public IList<Physician> GetPhysician()
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return physicianDao.getPhysician();
        }

        public Physician CreatePhysician(Physician p)
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return physicianDao.createPhysician(p);
        }

        public Physician UpdatePhysician(Physician p)
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return physicianDao.updatePhysician(p);
        }

        public IList<PVR> GetPVR(string id)
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return pvrDao.getPVR(id);
        }
        public PVR CreatePVR(PVR p, string id)
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
            {
                PVR pvr = pvrDao.createPVR(p, id);
                if (pvr == null)
                    throw new WebFaultException<string>("Patient does not exist", HttpStatusCode.BadRequest);
                else
                    return pvr;
            }
        }

        public Prescription GetPrescription(string id)
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return prescriptionDao.getPrescription(id);
        }

        public Prescription CreatePrescription(Prescription p)
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return prescriptionDao.createPrescription(p);
        }

        public Prescription UpdatePrescription(Prescription p)
        {
            var key = WebOperationContext.Current.IncomingRequest.Headers["key"];
            if (key == null)
                throw new WebFaultException<string>("The api key is null or not in header.", HttpStatusCode.BadRequest);
            else if (!ValidateKey(key))
                throw new WebFaultException<string>("invalid key", HttpStatusCode.BadRequest);
            else
                return prescriptionDao.createPrescription(p);
        }

        private bool ValidateKey(string key)
        {
            Tenant t = tenantDao.getTenantByKey(key);
            if (t != null && t.guid == key)
                return true;
            else
                return false;
        }
    }
}
