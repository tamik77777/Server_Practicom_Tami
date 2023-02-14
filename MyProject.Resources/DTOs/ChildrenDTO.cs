using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public enum eStatusLessonDTO { פעיל = 1, מתארגן = 2, מבוטל = 3 };
    public class ChildrenDTO
    {
        public int IdChild { get; set; }
        [ForeignKey("Parent")]
        public int IdParent { get; set; }
        public ParentDTO Parent { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string TzChild { get; set; }

        public ChildrenDTO()
        {

        }

        public ChildrenDTO(int idChild, int idParent, ParentDTO parent, string name, DateTime birthDate, string tzChild)
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
