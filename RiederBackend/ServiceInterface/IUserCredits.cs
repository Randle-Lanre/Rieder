using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiederBackend.ServiceInterface
{
    interface IUserCredits
    {
        /// <summary>
        /// get user, check that he has nothing less than 10 credits,
        /// if the user has made(at least 3) previous rents and not defaulted
        /// a minimum of 5 credits would be accepted
        /// 
        /// </summary>
        string user(string user);


    }
}
