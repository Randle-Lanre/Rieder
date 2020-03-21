using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using RiederBackend.Entities;
using RiederBackend.Helpers;
using RiederBackend.ServiceInterface;

namespace RiederBackend.Services
{
    public class UserServices : IUserServices
    {

        /*
         * hard coded users, users should be stored in db with hashed passwords
         *
         */
        private List<User> _user = new List<User>
        {
            new User {Id=1, FirstName = "mike", LastName = "Pablo", Username = "Mikelee", Password = "test"}
        };

        //------------------------------------
        private readonly AppSettings _appSettings;

        public UserServices(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }


        public User Authenticate(string username, string password)
        {
            var user = _user.SingleOrDefault(x => x.Username == username && x.Password == password);
            
            //return  null if user not found
            if (user == null)
                return null;

            //authentication successful generate jwt token
            var tokenHandler = new j
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
