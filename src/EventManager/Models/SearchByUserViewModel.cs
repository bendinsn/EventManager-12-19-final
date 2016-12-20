using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models
{
    public class SearchByUserViewModel
    {
        [Required]
        [Display(Name = "Artist Name")]
        public string ID { get; set; }
        
    }
}
