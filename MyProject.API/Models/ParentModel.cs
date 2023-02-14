using MyProject.Common.DTOs;
using System;

namespace MyProject.WebAPI.Models
{
    public class ParentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime Date { get; set; }
        public eMinDTO Min { get; set; }
        public eHospitalDTO Hospital { get; set; }
    }
}
