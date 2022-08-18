using System;

namespace Classes_Excercise_One // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car
            {
                Make = "Honda",
                Model = "HRV",
                Year = 2015
            };

            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Year: {myCar.Year}");
        }
    }
}