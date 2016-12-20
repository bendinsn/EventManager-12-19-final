using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;

namespace EventManager.Models
{
    public class UserCalendar
    {
        [Required]
        public int UserCalendarID { get; set; }

        [Required]
        public string UserID { get; set; }

        [Required]
        public int EventID { get; set; }
    }
}
