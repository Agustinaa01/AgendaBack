﻿using System.ComponentModel.DataAnnotations;
using Agenda_Tup_Back.Models.Enum;

namespace Agenda_Tup_Back.DTO
{
    public class UserForCreation
    {
        [Required]
        public string UserName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }


    }
}
