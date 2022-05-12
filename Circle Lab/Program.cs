using System;

namespace Circle_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            Console.WriteLine("Welcome to the Circle Tester.");

            bool isValidDouble = true;
            double myRadius;
            string answer;
            int myCount = 0;
            do
            {
                Console.WriteLine("Please enter a radius:");
                answer = Console.ReadLine();
                isValidDouble = double.TryParse(answer, out myRadius);
                if (isValidDouble == false)
                {
                    Console.WriteLine("Invalid Radius");
                    Console.WriteLine("Please enter a radius:");
                    answer = Console.ReadLine();
                    isValidDouble = double.TryParse(answer, out myRadius);
                } while (isValidDouble == false) ;

                Circle myCircle = new Circle(myRadius);
                myCount++;

                myCircle.CalculateCircumference(myRadius);

                Console.WriteLine($"{myCircle.CalculateFormattedCircumference()}");

                myCircle.CalculateArea(myRadius);
                Console.WriteLine($"{myCircle.CalculateFormattedArea()}");

                Console.WriteLine("Do you want to continue? (y/n)");
                answer = Console.ReadLine();
                if (answer != "y")
                {
                    cont = false;
                }
            } while (cont == true);
            Console.WriteLine($"You built {myCount} circles\n");
            Console.WriteLine("Goodbye!");
        }
    }
}
