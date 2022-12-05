using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels
{
    public class Lecturer
    {

        public int LecturerId { get; set; }

        [Required]
        [MinLength(2)]
        public string LecturerName { get; set; } = null!;

        [Range(18, 100)]
        public int Age { get; set; }


        //foreign key back to Department
        public int? DepartmentId { get; set; }

        //Not needed BUT its fierce handy to know the department without having to query using DeartmentID
        public Department? Department { get; set; }

    }
}
