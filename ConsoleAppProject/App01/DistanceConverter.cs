using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Alastair Fox version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        private double fromDistance;
        private double toDistance;

        private double fromUnit;
        private double toUnit;

        /// <summary>
        /// This method will output a heading, ask for the
        /// input for miles, calculate and output the same
        /// distance in feet.
        /// </summary>
        public void Run()
        {
            OutputHeading();
            SelectUnit();
            fromDistance = InputDistance($"Please enter the distance in {fromDistance} > !");
            //CalculateFeet();
            OutputDistance();
        }
        private string SelectUnit()
        {
            Console.WriteLine("Please select your unit\n");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Metres");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                return "Miles";
            }
            else if (choice == "2") 
            {
                return "Feet";
            }
            else if (choice == "3") 
            {
                return "Metres";
            }
            else return "NULL";
        }

        private static void OutputHeading()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine(" ========================");
            Console.WriteLine("    Distance Converter   ");
            Console.WriteLine("          by Al          ");
            Console.WriteLine(" ========================");
            Console.WriteLine();
        }

        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit} = {toDistance} {toUnit}!");
        }

        private void CalculateFeet()
        {
            //feet = miles * FEET_IN_MILES;
        }


        private double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string number = Console.ReadLine();
            return Convert.ToDouble(number);
        }
    }
}
