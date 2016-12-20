using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models
{
    public class Genre
    {
        [Required]
        public int GenreID { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public string GenreName { get; set; }
    }
}
