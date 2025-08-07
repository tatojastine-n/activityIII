using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ages = new List<int>();
            Console.WriteLine("Age Survey Analyzer");
            Console.WriteLine("Enter at least 20 ages (whole numbers). Type 'done' when finished:");

            while (ages.Count < 20)
            {
                Console.Write($"{ages.Count + 1}. ");
                string input = Console.ReadLine();

                if (input.ToLower() == "done" && ages.Count >= 20)
                    break;

                if (int.TryParse(input, out int age) && age > 0)
                {
                    ages.Add(age);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive whole number.");
                }
            }

            double average = ages.Average();
            int min = ages.Min();
            int max = ages.Max();

            int under18 = ages.Count(a => a < 18);
            int ages18to35 = ages.Count(a => a >= 18 && a <= 35);
            int ages36to60 = ages.Count(a => a > 35 && a <= 60);
            int over60 = ages.Count(a => a > 60);

            Console.WriteLine("\nSURVEY RESULTS");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Total responses:   {ages.Count,10}");
            Console.WriteLine($"Average age:       {average,10:F1} years");
            Console.WriteLine($"Youngest age:      {min,10} years");
            Console.WriteLine($"Oldest age:        {max,10} years");
            Console.WriteLine("\nAGE BRACKETS");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Under 18:          {under18,10}");
            Console.WriteLine($"18-35 years:       {ages18to35,10}");
            Console.WriteLine($"36-60 years:       {ages36to60,10}");
            Console.WriteLine($"Over 60:           {over60,10}");
        }
    }
}
