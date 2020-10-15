using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class CinemaHall
    {
        public List<Movie> Movies { get; set; }
        public int Id { get; set; }
        [Required]
        [Display(Name = "Hall number")]
        public int Nr { get; set; }
        [Required]
        [Display(Name = "Number of seats")]
        public int Seats { get; set; }
    }
}
