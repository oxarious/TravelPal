namespace TravelPal
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Countries Country { get; set; }

        public User(string username, string password, Countries country)
        {
            Username = username;
            Password = password;
            Country = country;
        }

    }
}
