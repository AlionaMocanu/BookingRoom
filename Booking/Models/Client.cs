using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Booking.Models
{


    public class Client
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string ClientName { get; set; }
        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        public bool Insurance { get; set; }

        public Client()
        {

        }

    }
}