using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels
{
    public enum Campus
    {
        Tallaght  = 1,
        KevinSt   = 2,
        AungierSt = 3
    }

    public class Department
    {
        public int DepartmentId { get; set; }

        [Required]
        public string DepartmentName { get; set; } = "";

        [Required]
        public Campus eCampus { get; set; }


        //list of lecturers for department
        public virtual ICollection<Lecturer>? Lecturers { get; set; }

    }
}
