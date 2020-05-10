using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RiederBackend.Entities;

namespace RiederBackend.ServiceInterface
{
    public  interface IUserServices
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();




    }
}
