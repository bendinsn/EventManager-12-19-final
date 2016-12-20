using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models
{
    public class NewEventViewModel
    {
        [Required]
        [Display(Name = "Event Name")]
        public string EventName { get; set; }

        [Required]
        [Display(Name = "Event Date")]
        public DateTime Time { get; set; }

        [Required]
        public string Venue { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreID { get; set; }
        
    }
}
