Console.WriteLine("This is my test for find centimeterPerMeter");

double maxValue = 10000.0;
double centimeterPerMeter = 100;

Console.WriteLine("Input you centimeter");

double centimeter = Convert.ToDouble(Console.ReadLine());

if (centimeter < maxValue || centimeter > maxValue)
{
    double meter;
    meter = centimeter / centimeterPerMeter;
    Console.WriteLine("you centimeterPerMeter equal : " + meter + " m ");
}
Console.ReadKey();

int number1;
number1 = 24;

Console.WriteLine("my number is {0:e}", number1);