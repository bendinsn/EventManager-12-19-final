using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models
{
    public class SearchByGenreViewModel
    {
        [Required]
        [Display(Name = "Genre")]
        public int ID { get; set; }
        
    }
}
