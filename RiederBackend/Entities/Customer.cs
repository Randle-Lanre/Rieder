﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiederBackend.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public int Age { get; set; }

        public DateTime DateOfRegistration { get; set; }


    }
}
