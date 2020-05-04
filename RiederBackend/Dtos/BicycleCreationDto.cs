using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RiederBackend.Dtos
{
    public class BicycleCreationDto
    {
        [Required]
        [StringLength(40)]
        public string Brand { get; set; }

        //the type would indicate if the bike is a mountain bike or a regular bike
        [Required]
        [StringLength(40)]
        public string Type { get; set; }

        //this would indicate the bicycle capacity 
        [StringLength(4)]
        public decimal Capacity { get; set; }

        //this would  indicate the maximum speed of the bike
        [StringLength(3)]
        public int Speed { get; set; }

    }
}
