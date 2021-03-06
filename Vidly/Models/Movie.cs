﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter movie's name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date Released")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        [Required]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Required]
        [Range(1,20)]
        public int NumbetInStock { get; set; }

        public byte GenreId { get; set; }

        public Genre Genre { get; set; }

    }
}