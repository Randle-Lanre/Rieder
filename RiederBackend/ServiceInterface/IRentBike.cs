using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiederBackend.ServiceInterface
{
    //user cannot rent more than 3 bikes at the same time 
    //use a -has a- relationship for checking user credit 

    /// <summary>
    /// Service interface deals with the process of renting a bike
    /// check user is authenticated
    /// check user is authorized
    /// check user doesn't have any violations (defaults can be met if any)
    /// 
    /// </summary>
    interface IRentBike
    {
    }
}
