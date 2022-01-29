using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "profile Picture URL")]
        public string profilePictureURL { get; set; }

        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Display (Name ="Biography")]
        public string Boi { get; set; }

        public List<Movie_Actor> Movie_Actors { get; set; }
    }
}
