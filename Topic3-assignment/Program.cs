using System.Net.NetworkInformation;

namespace Topic3_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sammy

            int roomNumber, graduationYear, degreesCelsius;
            double price, radiusCircle, areaCircle, degreesFahrenheit;
            string className, fullName;
            const double Pi = 3.141592653589793;

            roomNumber = 29;
            price = 2.99;
            className = "Computer Science";
            fullName = "Sammy N.";
            graduationYear = 2028;

            Console.WriteLine("This is room # " + roomNumber + ".");
            Console.WriteLine("The price is " + price.ToString("C") + ".");
            Console.WriteLine("I am learning a bit about " + className + "!");
            Console.WriteLine("My name is " + fullName + " and I'll graduate in " + graduationYear + ".");

            Console.WriteLine();

            Console.WriteLine("I will now calculate the area of a circle with a radius of 43'.");
            Console.WriteLine();
            radiusCircle = 43;
            areaCircle = Pi * (radiusCircle * radiusCircle);
            Console.WriteLine("The area is: " + Math.Round(areaCircle, 2) + " squred feet.");

            Console.WriteLine();
            degreesCelsius = 26;
            degreesFahrenheit = degreesCelsius * 9 / 5 + 32;
            Console.WriteLine("When it is " + degreesCelsius + "°C outside, it is also " + Math.Round(degreesFahrenheit) + "°F.");
        }
    }
}
