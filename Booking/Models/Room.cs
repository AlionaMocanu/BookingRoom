using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Booking.Models
{ 
   

    public class Room
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Range(1, 4)]
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }

        [Required]
        [Range(1,75)]
        [Display(Name = "Capacity of People")]
        public int CapacityOfPeople { get; set; }
     
        public Room()
        {

        }
    }
}