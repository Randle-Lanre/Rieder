using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RiederBackend.Dtos
{
    public class CustomerCreationDto
    {
        [Required]
        [StringLength(40)]
        public string LastName { get; set; }
        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }

        [StringLength(2)]
        public int Age { get; set; }
        //TODO: add correct datetime validation
        public DateTime DateOfRegistration { get; set; }
    }
}
