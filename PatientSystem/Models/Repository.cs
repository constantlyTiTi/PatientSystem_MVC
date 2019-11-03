using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace PatientSystem.Models
{
    public class Repository
    {
        private static List<Patient> _patientList=new List<Patient>();
        
        public IEnumerable<Patient> PatientList
        {
            get
            {
                return _patientList;
            }
        }

        public void AddPatient(Patient newPatient)
        {
            _patientList.Add(newPatient);
        }
    }
}
