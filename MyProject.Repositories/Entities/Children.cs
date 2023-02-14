using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{

  
    public class Children
    {
        [Key, Required]
        public int IdChild { get; set; }
        [ForeignKey("Parent")]
        public int IdParent { get; set; }
        public Parent Parent { get; set; }
        public string Name { get; set; }    
        public DateTime BirthDate { get; set; }
        public string TzChild { get; set; }  
        

        public Children() 
        {

        }

        public Children(int idChild, int idParent, Parent parent, string name, DateTime birthDate, string tzChild)
        {
            IdChild = idChild;
            IdParent = idParent;
            Parent = parent;
            Name = name;
            BirthDate = birthDate;
            TzChild = tzChild;
        }
    }
}
