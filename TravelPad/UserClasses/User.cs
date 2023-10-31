using System.Collections.Generic;
using TravelPal.TravelClasses;

namespace TravelPal
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Countries Country { get; set; }

        public List<Travel> AllTravels = new();
        public User(string username, string password, Countries country)
        {
            Username = username;
            Password = password;
            Country = country;


        }


    }
}
