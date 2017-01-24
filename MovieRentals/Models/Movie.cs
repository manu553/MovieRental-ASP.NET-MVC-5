using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [StockCantBeZero]
        public int Stock { get; set; }

        public byte NumberAvailable { get; set; }

        public Genre GenreType { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreTypeId { get; set; }
    }

    // /movies/random
}