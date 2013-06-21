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

returns records for all patients in the database.
###Sample JSON 