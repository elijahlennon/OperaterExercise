using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for division, create two interger variables called a and b

            int a = 17; //decleration  & initialization
            int b = 4;
            var qoutient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} = {qoutient} remainder {remainder}");

            Console.WriteLine("Please enter the radius of your circle:");
            var userInput = Console.ReadLine();

            var radius = double.Parse(Console.ReadLine()); 

            var area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}.");

        }

        


          

        
    }
}
