﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Amenities
    {
        public int ID { get; set; }

        [Required]
        public Name Name { get; set; }

        
    }
    public enum Name
    {
        Minifridge,
        Jacuzzi,
        Bidet,
        Masseuse,
    }
}
