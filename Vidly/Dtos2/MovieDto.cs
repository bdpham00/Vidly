using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos2
{
    public class MovieDto
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        //[StockCannotBeZero]
        //[Range(1,20)]
        public int NumberInStock { get; set; }
    }
}