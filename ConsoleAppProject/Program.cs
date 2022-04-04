﻿using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Alastair Fox 04/04/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("                 by Alastair Fox                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            string[] choices = new string[]
          {
                "Distance Converter",
                "BMI Calculator",
                "Students Grades",
                "Social Network"
          };

            ConsoleHelper.OutputTitle(" Please select the App you would like to use >   ");
            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                DistanceConverter app01 = new DistanceConverter();
                app01.Run();
            }
            else if (choice == 2)
            {
                BMI_Calculator app02 = new BMI_Calculator();
                app02.Run();
            }
            else if (choice == 3)
            {
                StudentGrades app03 = new StudentGrades();
                app03.Run();
            }
            else if (choice == 4)
            {
                NewsApp app04 = new NewsApp();
                app04.Run();
            }
        }
    }
}
