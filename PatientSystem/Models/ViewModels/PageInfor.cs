using System;
namespace PatientSystem.Models.ViewModels
{
    public class PageInfor
    {
        public int TotalItems { get; set; }
        public int ItemPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages =>
            (int)Math.Ceiling(((decimal)TotalItems / (decimal)ItemPerPage));
    }
}
