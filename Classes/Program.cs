namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Explorer";
            myCar.Year = 2004;

            Console.WriteLine($"My car is a {myCar.Make} {myCar.Model} year {myCar.Year}.");
        }
    }
}
