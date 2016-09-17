using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public int? GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        [StockCannotBeZero]
        //[Range(1,20)]
        public int NumberInStock { get; set; }

        public int NumberAvailable { get; set; }
    }

    // movies/random
}