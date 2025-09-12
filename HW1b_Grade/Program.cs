// HW1b Grade

// Your Name: Jenny Phan
// Did you seek help ? If yes, specify the helper or web link here: 
/* I asked Microsoft CoPilot to give me an example of string interpolation to better understand it. 
 It gave me this: 
"string firstName = "Taylor";
string lastName = "Jordan";
int age = 22;

Console.WriteLine($"Hello, {firstName} {lastName}! You are {age} years old.");" */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double HWork;
            double Parti;
            double e1;
            double e2;
            double e3;

            double sum;
            double sumone;
            double sumtwo;
            double sumthree;
            double sumfour;
            double sumfive;

            const double multione = .15;
            const double multitwo = .20;
            const double multithree = .25;

            string FName;
            string LName;
            string StuID;
            string HWorkAsString;
            string PartiAsString;
            string e1AsString;
            string e2AsString;
            string e3AsString;


            Console.WriteLine("What is your first name?");
            FName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            LName = Console.ReadLine();
            Console.WriteLine("What is your student id?");
            StuID = Console.ReadLine();


            //one = .15
            //hw = 20, e1 and part = 15, e2-3 = 25
            Console.WriteLine("What is your overall percentage grade for homeworks?");
            HWorkAsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for participation?");
            PartiAsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for Exam 1?");
            e1AsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for Exam 2?");
            e2AsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for Exam 3?");
            e3AsString = Console.ReadLine();

            HWork = Convert.ToDouble(HWorkAsString);
            Parti = Convert.ToDouble(PartiAsString);
            e1 = Convert.ToDouble(e1AsString);
            e2 = Convert.ToDouble(e2AsString);
            e3 = Convert.ToDouble(e3AsString);

            sumone = HWork * multitwo;
            sumtwo = Parti * multione;
            sumthree = e1 * multione;
            sumfour = e2 * multithree;
            sumfive = e3 * multithree;

            sum = sumone + sumtwo + sumthree + sumfour + sumfive;

            Console.WriteLine($"{FName} {LName} ({StuID}), your final grade is " + sum.ToString("N2") + "%");

            Console.ReadKey();
        }
    }
}
