using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models
{
    public class Event
    {
        [Required]
        public int EventID { get; set; }

        [Required(ErrorMessage = "The event must have a name.")]
        public string EventName { get; set; }

        public ApplicationUser Artist { get; set; }
        public string ArtistID { get; set; }

        [Required(ErrorMessage = "You must set a time for the event.")]
        public DateTime Time { get; set; }

        [Required(ErrorMessage = "You must list the event's location.")]
        public string Venue { get; set; }

        public int GenreID { get; set; }
        public Genre Genre { get; set; }
    }
}
