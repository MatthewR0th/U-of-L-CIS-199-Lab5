//Grading ID: K1791
//Lab 5
//11 October 2020
//CIS 199-02
//This lab takes temperatures from user input, adds them to a running total, and displays a mean temperature

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SENTINEL = 999; // The stopping value for input
            const int MIN_TEMP = -20; // Minimum valid temperature
            const int MAX_TEMP = 130; // Maximum valid temperature
            int count = 0;            // Count of valid temperatures
            int temp;                 // Input temperature
            double sum = 0;           // Running total of temps
            double mean;              // Mean temperature
            bool validTemp;           // Valid temp?

            WriteLine($"Enter temperatures from {MIN_TEMP} to {MAX_TEMP} ({SENTINEL} to stop)");

            // Priming read
            Write("Enter temperature: ");
            validTemp = (int.TryParse(ReadLine(), out temp) && (temp >= MIN_TEMP) && (temp <= MAX_TEMP));

            // Loop until sentinel is entered
            while (temp != SENTINEL)
            {
                if (validTemp) // Valid, so count it
                {
                    sum += temp;
                    ++count;
                }
                else // Not valid
                {
                    WriteLine($"Valid temperatures range from {MIN_TEMP} to {MAX_TEMP}. Please reenter temperature.");
                }

                // Read next input
                Write("Enter temperature: ");
                validTemp = (int.TryParse(ReadLine(), out temp) && (temp >= MIN_TEMP) && (temp <= MAX_TEMP));
            }

            // Summarize entered data
            mean = sum / count; // May worry about 0/0 but not a problem for doubles
            WriteLine($"\nYou entered {count} valid temperatures.");
            WriteLine($"The mean temperature is {mean:F1} degrees.");

        }
    }
}
