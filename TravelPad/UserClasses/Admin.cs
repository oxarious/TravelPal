namespace TravelPal
{

    public class Admin : IUser
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public Countries Country { get; set; }

    }
}
