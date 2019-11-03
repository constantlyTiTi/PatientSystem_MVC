using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatientSystem.Models;
using PatientSystem.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PatientSystem.Controllers
{
    public class HomeController : Controller
    {
        private Repository _repository;
        public int pageSize=2;
        public HomeController(Repository repo)
        {
            this._repository = repo;
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Index(Patient newPatient)
        {
            newPatient.RegisterTime = DateTime.Now;
            _repository.AddPatient(newPatient);
            return View("ThankYouPage", newPatient);
        }

        //public ViewResult PatientList(int page = 1)
        //{
        //    return View(_repository.PatientList
        //    .OrderBy(p => p.Name)
        //        .Skip((page - 1) * pageSize)
        //        .Take(pageSize)
        //    );
        //}

        public ViewResult PatientList(int page = 1)
        {
            //PatientListViewModel patientListViewModel = new PatientListViewModel();
            //PageInfor pageInfor = new PageInfor{
            //    CurrentPage = page,
            //    ItemPerPage = pageSize,
            //    TotalItems = _repository.PatientList.Count()
            //};
            //patientListViewModel.Patients = _repository.PatientList
            //    .Where(x => maritalStatus == null || x.MaritalStatus == maritalStatus)
            //.OrderBy(x => x.Name)
            //.Skip((page - 1) * pageSize)
            //.Take(pageSize);

            //patientListViewModel.PageInfor = pageInfor
            //;

            return View(new PatientListViewModel
            {
                Patients = _repository.PatientList
                //.Where(x => maritalStatus == null || x.MaritalStatus == maritalStatus)
                .OrderBy(x => x.Name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                ,

                PageInfor = new PageInfor
                {
                    CurrentPage = page,
                    ItemPerPage = pageSize,
                    TotalItems = _repository.PatientList.Count()
                }
            });
        }

        public ViewResult ThankYouPage(Patient aPatient)
        {
            return View("ThankYouPage");
        }
        //public ViewResult ThankYouPage(int id)
        //{
        ////Patient patient = Repository.PatientList;
        //return View(_repository.PatientList
        //.Where );
    }
}
