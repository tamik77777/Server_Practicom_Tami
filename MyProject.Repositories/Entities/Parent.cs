using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public enum eMin { זכר = 1, נקבה = 2};
    public enum eHospital { לאומית = 1, מכבי = 2 };
    public class Parent
    {
        [Key, Required]
        public int IdParent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime Date { get; set; }
        public eMin Min { get; set; }  
        public eHospital Hospital { get; set; }    
       
        public Parent()
        {

        }

        public Parent(int id, string firstName, string lastName, string tz, DateTime date, eMin min, eHospital hospital)
        {
            IdParent = id;
            FirstName = firstName;
            LastName = lastName;
            Tz = tz;
            Date = date;
            Min = min;
            Hospital = hospital;
        }
    }
}
