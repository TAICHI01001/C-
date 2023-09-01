// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxValue = 10000.0;
            double centimeterPerMeter = 100.0;
            Console.WriteLine("Input you centimeter");
            double centimeter = Convert.ToDouble(Console.ReadLine());


            if (centimeter < maxValue || centimeter > maxValue)
            {
                double meter;
                meter = centimeter / centimeterPerMeter;
                Console.WriteLine(meter);
            }
            // Console.WriteLine("Hello World!, My name is TaiChi you can call me Well", "TaiChi");
            // Console.WriteLine("Hello World!, My name is {0} you can call me {1} ", "TaiChi", "Well");

        }
    }
}