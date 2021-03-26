using System;

namespace AmalAPI.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public double CountryCode { get; set; }
        public double CityCode { get; set; }
        public int BloodGroupId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string Gender { get; set; }
        public string Ethnicity { get; set; }

        public string Religion { get; set; }

        public DateTime DOB { get; set; }

        public DateTime DOD { get; set; }

        public string PatientAddress { get; set; }

        public int MrNo { get; set; }

        public double MobileNumber { get; set; }

        public double EmergencyContactPerson { get; set; }

        public double EmergencyContactMobNo { get; set; }

        public string PatientMiddleName { get; set; }

        public string CNIC { get; set; }
        public string Passport { get; set; }

        public DateTime DMLInsertDate { get; set; }

        public DateTime DMLInsertBy { get; set; }











    }
}