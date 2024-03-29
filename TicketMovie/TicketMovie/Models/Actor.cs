﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMovie.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is required")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name="Full Name")]
        [Required(ErrorMessage ="Full Name is required")]
        [StringLength(70, MinimumLength =3,ErrorMessage ="Full name must be between 3 and 70 chars")]
        public string Name { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage ="Biography is required")]

        public string Bio { get; set; }
        //relationship
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
