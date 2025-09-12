// HW1a Sales Total

// Your Name: Jenny Phan
// Did you seek help ? No, I did not seek help. If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;

            double sum;
            double sumtwo;

            const double multiplier = .085;

            string num1AsString;
            string num2AsString;

            Console.WriteLine("What is the product name of the item you are purchasing?");
            string productname = Console.ReadLine();

            Console.WriteLine($"How many {productname}s do you want to buy?");
            num1AsString = Console.ReadLine();

            Console.WriteLine($"What is the price for each {productname}?");
            num2AsString = Console.ReadLine();

            num1 = Convert.ToDouble(num1AsString);
            num2 = Convert.ToDouble(num2AsString);

            sum = num1 * num2;

            Console.WriteLine("Your subtotal for your bill is $" + sum.ToString("N2"));

            sumtwo = sum * multiplier;

            Console.WriteLine($"Your sales tax for your bill is ${sumtwo.ToString("N2")}");

            sum = sumtwo + sum;

            Console.WriteLine($"Your total for the bill is ${sum.ToString("N2")}");

            Console.ReadKey();
        }
    }
}
