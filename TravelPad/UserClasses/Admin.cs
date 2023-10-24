namespace TravelPal
{

    public class Admin : IUser
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public Countries Country { get; set; }

        public Admin(string username, string password, Countries countruy)
        {
            Username = username;
            Password = password;
            Country = countruy;
        }

    }

}
