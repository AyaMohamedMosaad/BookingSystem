﻿using System.ComponentModel.DataAnnotations;

namespace BookingSystem.ViewModel
{
    public class RegisterViewModel
    {
        
            [Required]
            public string UserName { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Compare("Password")]
            public string ConfirmPassword { get; set; }

            [Required]
            public string Address { get; set; }
        
    }
}
