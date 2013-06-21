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
