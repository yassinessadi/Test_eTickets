﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Movie_Actor
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
