using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RiederBackend.Entities
{
    public class Seller
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
       
        public string LastName { get; set; }
        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }

        public ICollection<Bicycle> Bicycles { get; set; }






    }
}
