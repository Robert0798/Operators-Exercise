using System.Threading.Channels;

namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCirlce(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static void PrintAreaOfCircle()
        {
            Console.WriteLine("what is the radius of the circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of the circle with a radius of {radius} is {AreaOfCirlce(radius), 3}");
        }
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;


            int sum = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            
            
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            
            PrintAreaOfCircle();
            
            
        }
    }
}
