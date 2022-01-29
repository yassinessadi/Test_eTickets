using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string profilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Boi { get; set; }
        //Relations
        public List<Movie> Movies { get; set; }
    }
}
