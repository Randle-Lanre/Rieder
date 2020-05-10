using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RiederBackend.Dtos
{
    public class SellerDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]

        public string LastName { get; set; }
        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }

    }
}
