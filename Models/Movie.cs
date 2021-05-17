using System;
using System.ComponentModel.DataAnnotations;

namespace RazorMovies.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "Title must be between 3 e 60 characters.")]
        [Required(ErrorMessage = "Title must be informed.")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z-ÁÀÂÃÉÈÊÍÓÔÕÖÚÇÑ]+[a-záàâãéèêíïóôõöúçñA-Z''-'\s]*$", ErrorMessage = "Invalid characters.")]
        [Required(ErrorMessage = "Genre must be informed.")]
        [StringLength(30, ErrorMessage = "Maximum 30 characters.")]
        public string Genre { get; set; }

        [Range(0, 100, ErrorMessage = "Price must be between 1 and 100.")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Price must be informed.")]
        public double Price { get; set; }

        public int DirectorID { get; set; }

        public Director Director { get; set; }
    }
}
