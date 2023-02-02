using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotent = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
                Console.WriteLine($" {a} / {b} is {quotent} remainder {remainder}");
            
            Console.WriteLine("Please give me the radius of a Circle, and I will calculate the area");
            var radius = double.Parse(Console.ReadLine());
            var answer = AreaOfCircle(radius);
            Console.WriteLine($"The Area of a circle with a radius of {radius} is {answer}");
        }
        public static double AreaOfCircle(double radius)
        {
            return (Math.PI * radius * radius);


        }
    }
        
}
