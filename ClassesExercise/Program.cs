using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Subaru";
            myCar.Model = "Crosstrek";
            myCar.Year = 2019;

            Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}");
        
        }
    }
}
