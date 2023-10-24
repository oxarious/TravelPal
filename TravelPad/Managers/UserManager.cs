using System;
using System.Collections.Generic;

namespace TravelPal
{

    public static class UserManager
    {
        public static List<User> allUsers = new();
        public static List<Admin> allAdmins = new();

        //public string SignedInUser { get; set; }



        public static void RemoveUser()
        {

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
                    return true;
                }
            }
            return false;
        }
        public static User CreateUser(string username, string password, Countries country)
        {
            return new User(username, password, country);
        }


        public static void GenerateDefaultUsers()
        {
            User user = new User("user", "password", Countries.Afghanistan);
            allUsers.Add(user);
        }
        public static void GenerateAdmin()
        {
            Admin admin = new Admin("admin", "password", Countries.Afghanistan);
            allAdmins.Add(admin);
        }

        public static Countries ParseEnum(string enumToParse)
        {
            //return (Countries)Enum.Parse(typeof(Countries), enumToParse);
            Countries country = (Countries)Enum.Parse(typeof(Countries), enumToParse);
            return country;
        }

        //internal static User CreateUser(string text1, string text2, string? v)
        //{
        //    throw new NotImplementedException();
        //}

        //internal static User CreateUser(string text1, string text2, string? v)
        //{
        //    throw new NotImplementedException();
        //}
    }

}




