README
---------------

##Intro
-----
This is a simple RESTful api for patient medical data.

##Endpoints
-------
-Patient Record

  *http://emrservice.ironfoundry.me/PatientService.svc/patientrecord

-Patient Visit Record

  *http://emrservice.ironfoundry.me/PatientService.svc/patientrecord/{id}/pvr

-Insurance

  *http://emrservice.ironfoundry.me/PatientService.svc/insurance

-Pharmacist

  *http://emrservice.ironfoundry.me/PatientService.svc/pharmacist

-Physician

  *http://emrservice.ironfoundry.me/PatientService.svc/physician

#API Key
---------

This API key gives access to all operations.  For all api calls you must set a custom http header called "key" using this api key

        f81d4fae-7dec-11d0-a765-00a0c91e6bf6


#Supported Operations
---------
##Patient records
    GET http://emrservice.ironfoundry.me/PatientService.svc/patientrecord

Returns records for all patients in the database.

    GET http://emrservice.ironfoundry.me/PatientService.svc/patientrecord/{id}

Returns data for a single patient.

    POST http://emrservice.ironfoundry.me/PatientService.svc/patientrecord

Creates a patient record

    PUT http://emrservice.ironfoundry.me/PatientService.svc/patientrecord

Updates a patient record.

###Sample JSON Data

    {
       "Allergies": ['test', 'test'],
       "BillingAddress": null,
       "CurrentTabaccoUse": false,
       "DOB": null,
       "DaytimeNumber": null,
       "DrugHistory": null,
       "Email": null,
       "EmergencyContact": null,
       "Ethnicity": null,
       "EveningNumber": null,
       "FamilyHistory": null,
       "FamilyPhysician": null,
       "Immunizations": null,
       "LegalGuardian": null,
       "ListOfPhysicians": null,
       "ListOfPrescriptions": null,
       "ListOfProviders": null,
       "MaritalStatus": null,
       "PastTabaccoUse": false,
       "PatientName": null,
       "PhysicalAddress": null,
       "SexualOrientation": null,
       "SocialSecurityNumber": null
    }

###Sample Response JSON Data

    {
       "Id": "f032dbf0-24eb-436d-8686-214224373878",
       "Allergies": null,
       "BillingAddress": null,
       "CurrentTabaccoUse": false,
       "DOB": null,
       "DaytimeNumber": null,
       "DrugHistory": null,
       "Email": null,
       "EmergencyContact": null,
       "Ethnicity": null,
       "EveningNumber": null,
       "FamilyHistory": null,
       "FamilyPhysician": null,
       "Immunizations": null,
       "LegalGuardian": null,
       "ListOfPhysicians": null,
       "ListOfPrescriptions": null,
       "ListOfProviders": null,
       "MaritalStatus": null,
       "PastTabaccoUse": false,
       "PatientName": null,
       "PhysicalAddress": null,
       "SexualOrientation": null,
       "SocialSecurityNumber": null
    }

----------------------------------

##Patient Visit Record

    GET http://emrservice.ironfoundry.me/PatientService.svc/patientrecord/{PatientID}/pvr

Returns a list of patient visit records for a patient.

    POST http://emrservice.ironfoundry.me/PatientService.svc/patientrecord/{PatientID}/pvr

Creates a patient visit record for patient.

###Sample JSON Data

    {
       "BloodPressure": 0,
       "CourseOfTreatment": null,
       "Date": "1/1/1991",
       "HeartRate": 0,
       "Height": 0,
       "Symptoms": null,
       "Temperature": 0,
       "Weight": 0,
       "notes": null,
       "resonForVist": null
   }

###Sample Response JSON Data

    {
       "BloodPressure": 0,
       "CourseOfTreatment": null,
       "Date": "1/1/1991",
       "HeartRate": 0,
       "Height": 0,
       "Id": "416f5865-7038-4387-83b7-a0890a8b9446",
       "Symptoms": null,
       "Temperature": 0,
       "Weight": 0,
       "notes": null,
       "patientId": "f032dbf0-24eb-436d-8686-214224373878",
       "resonForVist": null
   }

--------------------------------------- 

##Insurance

    GET http://emrservice.ironfoundry.me/PatientService.svc/insurance

Returns a list of all insurance providers.

    GET http://emrservice.ironfoundry.me/PatientService.svc/insurance/{InsuranceId}

Returns data for a single insurance provider.

    POST http://emrservice.ironfoundry.me/PatientService.svc/insurance

Creates a new insurance provider

    PUT http://emrservice.ironfoundry.me/PatientService.svc/insurance

Updates an exisiting insurance provider.

###Sample JSON Data

    {
       "BillingAddress": null,
       "CompanyName": "testInsurance4",
       "ContactNumber": "111-111-1113",
       "GroupPolicy": "true",
       "PolicyHolderID": "30"
   }

###Sample Response JSON Data

    {
       "BillingAddress": null,
       "CompanyName": "testInsurance4",
       "ContactNumber": "111-111-1113",
       "GroupPolicy": "true?",
       "Id": "9947a857-0dd4-4d15-b61a-7a4f3f830326",
       "PolicyHolderID": "30"
    }
----------------------------------------------------

##Pharmacist

    GET http://emrservice.ironfoundry.me/PatientService.svc/pharmacist/{PharmacistId}

Returns a single pharmacist.

    POST http://emrservice.ironfoundry.me/PatientService.svc/pharmacist

Creates a pharmacist

    PUT http://emrservice.ironfoundry.me/PatientService.svc/pharmacist

Updates an exisitng pharmacist.

###Sample JSON Data

    {
       "PharmacistAddress": null,
       "PharmacistName": null,
       "PhoneNumber": null
    }

###Sample Response JSON Data

    {
       "Id": "f991f1a3-b204-484b-9261-ddcb5b54ea33",
       "PharmacistAddress": null,
       "PharmacistName": null,
       "PhoneNumber": null
    }
------------------------------

##Physician

    GET http://emrservice.ironfoundry.me/PatientService.svc/physician

Returns a list of all physicians.

    GET http://emrservice.ironfoundry.me/PatientService.svc/physician/{PhysicianId}

Returns a single physician.

    POST http://emrservice.ironfoundry.me/PatientService.svc/physician

Create a new physician.

    PUT http://emrservice.ironfoundry.me/PatientService.svc/physician

Update an existing physician

###Sample JSON Data

    {
       "PhoneNumber": null,
       "PhysicianAddress": null,
       "PhysicianName": null,
       "Speciality": "test"
    }

###Sample Response JSON Data

    {
       "Id": "c55f61a5-bc45-4b49-bd25-d874d10ae2be",
       "PhoneNumber": null,
       "PhysicianAddress": null,
       "PhysicianName": null,
       "Speciality": "test"
   }




