using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models
{
    public class SearchByVenueViewModel
    {
        [Required]
        [Display(Name = "Venue")]
        public string ID { get; set; }
        
    }
}
