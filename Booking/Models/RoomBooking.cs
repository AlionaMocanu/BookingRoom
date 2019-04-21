using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Booking.Models
{
    public class RoomBooking
    {
        [Key]
        [Display(Name = "Booking ID")]
        public string BookingID { get; set; }

        [Required]
        [Display(Name = "Room ID")]
        public int RoomID { get; set; }

        [Required]
        [Display(Name = "Client ID")]
        public string ClientID { get; set; }

        public bool TEAandCOFFE { get; set; }

        [Required]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Time")]
        public DateTime Time { get; set; }
        
        public RoomBooking()
        {

        }

    }
}