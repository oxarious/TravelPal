using System;
using System.Collections.Generic;
using TravelPal.TravelClasses;

namespace TravelPal
{
    public static class TravelManager
    {
        public static List<Travel> allTravels = new();



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
        //public static void RemoveTravel()
        //{
        //    foreach (Travel travel in allTravels)
        //    {

        //    }
        //}
        //private static WorkTrip AddWorkTrip()
        //{
        //    AllTravels.Add(AddWorkTrip());

        //}
        public static Countries ParseEnum(string enumToParse)
        {
            //return (Countries)Enum.Parse(typeof(Countries), enumToParse);
            Countries country = (Countries)Enum.Parse(typeof(Countries), enumToParse);
            return country;
        }

        //public static void RemoveTravel(Travel travel)
        //{

        //    allTravels.Remove(travel);

        //}

        //public static void GenerateTravel()
        //{
        //    WorkTrip workTrip = new WorkTrip(Countries.CongoRepublicOf, "Helsingborg", 1, "Gonna be lit");
        //    Vacation vacation = new Vacation(Countries.CongoRepublicOf, "Malmö", 1, false);
        //    allTravels.Add(vacation);
        //    allTravels.Add(workTrip);
        //    ListViewItem listViewItem = new ListViewItem();
        //    listViewItem.Tag = workTrip;
        //    listViewItem.Content = workTrip;
        //    allTravels.Add(workTrip);

        //}

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
