using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RiederBackend.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string LastName { get; set; }
        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(3)]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime RegistrationDate { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }

        public ICollection<Order> Orders { get; set; }




    }
}
