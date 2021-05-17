using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorMovies.Models
{
    public class Director
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "Name must be betwen 3 and 60 characters.")]
        [Required(ErrorMessage = "Name must be informed.")]
        public string Name { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
