using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public enum eMinDTO { זכר = 1, נקבה = 2 };
    public enum eHospitalDTO { לאומית = 1, מכבי = 2 };
    public class ParentDTO
    {
        public int IdParent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime Date { get; set; }
        public eMinDTO Min { get; set; }
        public eHospitalDTO Hospital { get; set; }

        public ParentDTO()
        {

        }

        public ParentDTO(int idParent, string firstName, string lastName, string tz, DateTime date, eMinDTO min, eHospitalDTO hospital)
        {
            IdParent = idParent;
            FirstName = firstName;
            LastName = lastName;
            Tz = tz;
            Date = date;
            Min = min;
            Hospital = hospital;
        }
    }
}
