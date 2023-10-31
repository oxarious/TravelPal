namespace TravelPal.TravelClasses
{
    public class Travel
    {
        public Countries Country { get; set; }


        public string Destination { get; set; }
        public int NumberOfTravelers { get; set; }



        public Travel(Countries country, string destination, int numberOfTravelers)
        {
            Country = country;

            Destination = destination;

            NumberOfTravelers = numberOfTravelers;



        }
        public virtual string GetInfo()
        {
            return $"Country: {Country}, Destination: {Destination}, How many travelers: {NumberOfTravelers}";
        }
    }
}
