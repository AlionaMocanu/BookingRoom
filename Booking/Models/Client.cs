using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Booking.Models
{
    public enum ClientType { CentreStaff, VolunteerGroups, ThirdParties}

    public class Client
    {
        [Key]
        [Display(Name = "Client ID")]
        public string ClientID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string ClientName { get; set; }
        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [EmailAddress]
        [Display(Name = "Email Address")]
        public EmailAddressAttribute Email { get; set; }
        [Required]
        public List<ClientType> ClientType { get; set; } 

        public bool Insurance { get; set; }

        public Client()
        {

        }

    }
}