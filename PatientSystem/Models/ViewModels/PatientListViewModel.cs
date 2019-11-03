using System;
using PatientSystem.Models;
using System.Collections.Generic;
namespace PatientSystem.Models.ViewModels
{
    public class PatientListViewModel
    {
        public IEnumerable<Patient> Patients { get; set; }
        public PageInfor PageInfor { get; set; }
    }
}
