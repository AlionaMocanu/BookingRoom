using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Booking.Models
{
    public class RoomBooking
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Room ID")]
        [ForeignKey("Rooms")]
        public int RoomID { get; set; }

        [Required]
        [Display(Name = "Client ID")]
        [ForeignKey("Clients")]
        public int ClientID { get; set; }

        public bool TEAandCOFFE { get; set; }

        [Required]
        [Display(Name = "Enter Time")]
        public DateTime EnterTime { get; set; }

        public virtual Client Clients { get; set; }
        public virtual Room Rooms { get; set; }
       
        
        public RoomBooking()
        {

        }

    }
}