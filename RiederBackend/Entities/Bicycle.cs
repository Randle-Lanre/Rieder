﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RiederBackend.Entities
{
    public class Bicycle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Brand { get; set; }

        //the type would indicate if the bike is a mountain bike or a regular bike
        [Required]
        [StringLength(255)]
        public string Type { get; set; }

        //this would indicate the bicycle capacity 
        public decimal Capacity { get; set; }

        //this would  indicate the maximum speed of the bike
        public int Speed { get; set; }
    }
}
