using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will allow the user to enter a measurement and it will convert the value to a different measurement
    /// </summary>
    /// <author>
    /// Alastair Fox version 1.4
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METERS_IN_MILES = 1609.34;
        public const double FEET_IN_METERS = 3.28084;

        public const string FEET = "Feet";
        public const string METERS = "Meters";
        public const string MILES = "Miles";

        public double fromDistance { get; set; }
        public double toDistance { get; set; }

        public string fromUnit { get; set; }
        public string toUnit { get; set; }

        /// <summary>
        /// This method contains the calculations required to convert between miles, feet and meters
        /// </summary>
        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == METERS && toUnit == MILES)
            {
                toDistance = fromDistance / METERS_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METERS)
            {
                toDistance = fromDistance * METERS_IN_MILES;
            }
            else if (fromUnit == METERS && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METERS;
            }
            else if (fromUnit == FEET && toUnit == METERS)
            {
                toDistance = fromDistance / FEET_IN_METERS;
            }
        }

        /// <summary>
        /// This method displays text asking the user to input the two units of measurements 
        /// </summary>
        public void ConvertDistance()
        {
            string[] choices = new string[]
            {
                FEET, METERS, MILES
            };

            Console.WriteLine($"\nSelect the distance unit you wish to convert from >\n ");
            int choice = ConsoleHelper.SelectChoice(choices);
            fromUnit = choices[choice - 1];
            Console.WriteLine($"Selected {fromUnit} ");

            Console.WriteLine($"\nSelect the distance unit you wish to convert to >\n ");
            choice = ConsoleHelper.SelectChoice(choices);
            toUnit = choices[choice - 1];
            Console.WriteLine($"\nSelected {toUnit} \n");

            fromDistance = ConsoleHelper.InputNumber($"\nEnter the distance in {fromUnit} >\n ");

            ConsoleHelper.OutputTitle($"\nConverting {fromUnit} to {toUnit} \n");

            CalculateDistance();

            OutputDistance();
        }

        /// <summary>
        /// This method will run the program and output text
        /// </summary>
        public void Run()
        {
            bool repeat = true;
            while (repeat)
            {
                ConsoleHelper.OutputHeading("Distance Converter");
                ConvertDistance();
            }
        }

        /// <summary>
        /// This method outputs a result of the distance that has been converted
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance} {fromUnit} =" +
                $" {toDistance} {toUnit}\n");
        }
    }
}