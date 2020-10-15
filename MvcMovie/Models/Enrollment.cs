using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public AppUser User { get; set; }

        [Display(Name = "Reservation Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = false)]
        public DateTime EnrollmentDate { get; set; }
    }
}
