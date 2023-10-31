using System;
using System.Collections.Generic;

namespace TravelPal
{

    public static class UserManager
    {
        public static List<IUser> allUsers = new();

        public static IUser signedInUser { get; set; }

        private static bool isInitialized = false;


        public static void InitializeUserManager()
        {
            if (!isInitialized)
            {
                GenerateDefaultUsers();
                isInitialized = true;
            }
        }

        public static bool RemoveUser()
        {
            return true;
        }
        public static bool UpdateUsername()
        {
            return true;
        }

        //Check if username exists in alluser-list, if exits, return false. if not exist, return true. 
        public static bool CheckUsernameAvailability(string username)
        {
            foreach (var user in allUsers)
            {
                if (user.Username == username)
                {
                    return false;
                }

            }
            return true;
        }
        public static bool CheckLogIn(string username, string password)
        {
            foreach (var user in allUsers)
            {
                if (user.Username == username && user.Password == password)
                {
                    SignInUser(user);
                    return true;
                }
            }
            return false;
        }

        public static void SignInUser(IUser user)
        {
            UserManager.signedInUser = user;
        }


        public static User CreateUser(string username, string password, Countries country)
        {
            return new User(username, password, country);
        }


        private static void GenerateDefaultUsers()
        {
            User user = new User("user", "password", Countries.CongoRepublicOf);
            allUsers.Add(user);

            Admin admin = new Admin("admin", "password", Countries.CongoRepublicOf);
            allUsers.Add(admin);

            WorkTrip workTrip = new WorkTrip(Countries.CongoRepublicOf, "Helsingborg", 1, "Gonna be lit");
            user.AllTravels.Add(workTrip);
            Vacation vacation = new Vacation(Countries.CongoRepublicOf, "Malmö", 1, false);
            user.AllTravels.Add(vacation);

        }

        public static void GenerateAdmin()
        {
            //Admin admin = new Admin("admin", "password", Countries.Afghanistan);
            //all.Add(admin);
        }

        public static Countries ParseEnum(string enumToParse)
        {
            //return (Countries)Enum.Parse(typeof(Countries), enumToParse);
            Countries country = (Countries)Enum.Parse(typeof(Countries), enumToParse);
            return country;
        }
        public static TravelType x(string enumToParse)
        {

            TravelType travelType = (TravelType)Enum.Parse(typeof(TravelType), enumToParse);
            return travelType;
        }



    }

}




