using TravelPal.TravelClasses;

namespace TravelPal
{
    public class WorkTrip : Travel
    {
        string MeetingDetails { get; set; }


        public WorkTrip(Countries country, string destination, int numberOfTravalers, string meetingDetails) : base(country, destination, numberOfTravalers)
        {
            MeetingDetails = meetingDetails;
        }

        public override string ToString()


        {
            return $"Country: {Country}, Destination:  {Destination}, No of Travelers {NumberOfTravelers}, Meeting details: {MeetingDetails} ";
        }
    }
}
