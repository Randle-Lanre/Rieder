using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.Threading.Tasks;

namespace RiederBackend.Entities
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }

        public Bicycle Bicycle { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReturnDate { get; set; }


    }
}
