using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkWeek3Problem1_BMI_calculator
{
    class Program                                                           // Evan Caraway, Srinivas Reddy Doma, Kipack Jeong
    {
        static void Main(string[] args)
        {
            BmiCalculator();                                                // Calling BMI Calculator method.            
        }
        /// <summary>
        /// Calcualate BMI using user inputs of weight in pounds and height in inches and returns classification of underweight, optimal or overweight.
        /// </summary>
        static void BmiCalculator()
        {
            Console.Write("Please enter your weight in pounds: ");          // ask user for weight.  
            //double weight = Convert.ToDouble(Console.ReadLine());         // save user input to weight.
            double.TryParse(Console.ReadLine(), out double weight);
            Console.Write("Please enter your height in inches: ");
            //double height = Convert.ToDouble(Console.ReadLine());
            double.TryParse(Console.ReadLine(), out double height);
            double bodyMassIndex = (weight * 703) / (Math.Pow(height, 2));  // foumula for BMI
            double bMi = Math.Round(bodyMassIndex, 2);                      // round double to 2 decimals

            if (bMi < 18.5)                                                 // use conditional if statement to check user inputs and display appropriate response.
            {
                Console.WriteLine($"Your Body Mass Index (BMI) is {bMi}.  Any BMI less than 18.5 is considered to be underweight.");
            }
            else if (bMi <= 25)
            {
                Console.WriteLine($"Your Body Mass Index (BMI) is {bMi}.  A sedentary persons weight is considered to be optimal if BMI is between 18.5 and 25 (inclusively).");
            }
            else
            {
                Console.WriteLine($"Your Body Mass Index (BMI) is {bMi}.  Any BMI greater than 25 is considered to be overweight.");
            }
        }

            
    }

}
