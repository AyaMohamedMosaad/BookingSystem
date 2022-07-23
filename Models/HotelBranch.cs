﻿using System.Collections.Generic;

namespace BookingSystem.Models
{
    public class HotelBranch
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public virtual List<Room> Room { get; set; }
        
    }
}
