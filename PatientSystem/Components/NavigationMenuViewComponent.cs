using System;
using System.Linq;
using PatientSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace PatientSystem.Components
{
    public class NavigationMenuViewComponent:ViewComponent
    {
        private Repository patientRepo=new Repository();
        public NavigationMenuViewComponent(Repository repo)
        {
            patientRepo = repo;
        }
        public IViewComponentResult Invoke()
       => View(patientRepo.PatientList
            .Select(p => p.MaritalStatus)
            .Distinct()
            .OrderBy(p => p));
    }
}
