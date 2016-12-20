using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;

namespace EventManager.Models
{
    public class Follow
    {
        [Required]
        public int FollowID { get; set; }

        [Required]
        public string FollowerID { get; set; }

        [Required]
        public string ArtistID { get; set; }
    }
}
