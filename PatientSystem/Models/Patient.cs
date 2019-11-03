using System;

namespace PatientSystem.Models
{
    //public enum MaritalStatusEnum{ Married, Single, Divorced, Widowed }

    public class Patient
    {
        private static int _patientId = 1;

        private int _id = 0;

        public Patient()
        {
            this._id = determinId();
        }
        public int Id 
        { 
            get { return this._id; }
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }
        public Boolean HasInsurance { get; set; }
        public Boolean HasOperationBefore { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime RegisterTime { get; set; }

        public int determinId()
        {
            return _patientId++;
        }

    }
}
