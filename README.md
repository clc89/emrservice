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

###Sample JSON


    {
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
       "Id": "f032dbf0-24eb-436d-8686-214224373878",
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

 