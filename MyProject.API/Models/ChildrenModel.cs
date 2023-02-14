using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using MyProject.Common.DTOs;

namespace MyProject.WebAPI.Models
{
    public class ChildrenModel
    {

        [ForeignKey("Parent")]
        public int IdParent { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string TzChild { get; set; }


    }
}
