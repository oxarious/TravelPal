namespace TravelPal.TravelClasses
{
    public class Travel
    {
        public Countries Country { get; set; }


        public string Destination { get; set; }
        public int NumberOfTravalers { get; set; }



        public Travel(Countries country, string destination, int numberOfTravalers)
        {
            Country = country;

            Destination = destination;

            NumberOfTravalers = numberOfTravalers;



        }
        public virtual string GetInfo()
        {
            return $"{Country}, {Destination}, {NumberOfTravalers}";
        }
    }
}
