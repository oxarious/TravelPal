using System;
using System.Collections.Generic;
using TravelPal.TravelClasses;

namespace TravelPal
{
    public static class TravelManager
    {
        public static List<Travel> allTravels = new List<Travel>();



        public static void AddTravel(Countries country, string destination, int numberOfTravelers)
        {

        }
        public static WorkTrip AddWorkTrip(Countries country, string destination, int numberofTravleres, string meetingDetails)
        {
            return new WorkTrip(country, destination, numberofTravleres, meetingDetails);



        }
        public static Vacation AddVacation(Countries country, string destination, int numberOfTravelers, bool isAllIncusive)
        {
            return new Vacation(country, destination, numberOfTravelers, isAllIncusive);
        }
        public static void RemoveTravel()
        {
            foreach (Travel travel in allTravels)
            {

            }
        }
        //private static WorkTrip AddWorkTrip()
        //{
        //    allTravels.Add(AddWorkTrip());

        //}
        public static Countries ParseEnum(string enumToParse)
        {
            //return (Countries)Enum.Parse(typeof(Countries), enumToParse);
            Countries country = (Countries)Enum.Parse(typeof(Countries), enumToParse);
            return country;
        }
        //public static void DoEverything()
        //{
        //    ListViewItem CreateListViewItem(Object x, string )
        //    {
        //        ListViewItem lvitem = new();
        //        lvitem.Tag = vacation;
        //        lvitem.Content = vacation;
        //        return lvitem;
        //    }
        //}
    }
}
