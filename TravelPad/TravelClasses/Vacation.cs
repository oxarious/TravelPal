using TravelPal.TravelClasses;

namespace TravelPal
{
    public class Vacation : Travel
    {
        public bool AllInclusive { get; set; }
        public Vacation(Countries country, string destination, int numberOfTravalers, bool allInclusive) : base(country, destination, numberOfTravalers)
        {
            AllInclusive = allInclusive;

        }


        public override string ToString()
        {

            if (AllInclusive)
            {
                return $" Country: {Country}, Destination: {Destination}, Number of Travelers {NumberOfTravelers}, All Inclusive? YES";
            }
            else
                return $" Country: {Country}, Destination: {Destination}, Number of Travelers {NumberOfTravelers}, All Inclusive? NO";
        }
    }
}
