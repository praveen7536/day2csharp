using System;

namespace day2assign
{
    public static class TemperatureConverter
    {
        public static double CeltoFar(string tempc)
        {
            double cel = double.Parse(tempc);
            double farenheit= (cel * 9 / 5) + 32;
            return farenheit;

        }
        public static double fartoCel(string tempf)
        {
            double far = double.Parse(tempf);
            double celsius = (far - 32) * 5 / 9;
            return celsius;

        }


    }
    
    class Program
    { 
        static void Main(string[] args)
        {
            double tempcel=0, tempfar;
            //cel to far
            Console.WriteLine("Enter Temperature in Celcius to change it into farenheit");
            tempcel =TemperatureConverter.CeltoFar(Console.ReadLine());
            Console.WriteLine("Temperature in farenheit is: " + tempcel);
            //far to cel
            Console.WriteLine("Enter Temperature in farenheit to change it into celcius");
            tempfar = TemperatureConverter.fartoCel(Console.ReadLine());
            Console.WriteLine("Temperature in Celcius is: "+ tempfar);







        }
    }
}
