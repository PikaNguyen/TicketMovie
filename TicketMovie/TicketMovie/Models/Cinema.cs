﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMovie.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Logo Cinema")]
        public string Logo { get; set; }
        [Display(Name="Name of Cinema")]
        public string Name { get; set; }
        public string Discription { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
