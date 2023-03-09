using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMovie.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Profile Picture")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name="Full name")]
        public string Name { get; set; }
        [Display(Name="Biography")]
        public string Bio { get; set; }
        // Cac moi Relationships
        public List<Movie> Movies { get; set; }
    }
}
