using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedMath
{
    class Program
    {
        static void Main(string[] args)
        {
            //takes an input from the user, multiplies it by 50, and prints the results to the console.
            int multiply;
            int userinput;
            multiply = 50;

            Console.WriteLine("enter a number: ");
            userinput = int.Parse(Console.ReadLine());
            int newnum = multiply;
            Console.WriteLine("your number x 50 is: " + userinput * 50);
            Console.ReadLine();


            //Takes an input from the user, adds 25 to it, and prints the result to the console.
            int add;
            int userInput2;
            add = 25;

            Console.WriteLine("Enter another number: ");
            userInput2 = int.Parse(Console.ReadLine());
            int newNum2 = add;
            Console.WriteLine("Your number + 25 is: " + userInput2 + 25);
            Console.ReadLine();


            //Takes an input from the user, divides it by 12.5, and prints the result to the console.
            double divide;
            double userInput3;
            divide = 12.5;

            Console.WriteLine("Enter another number: ");
            userInput3 = double.Parse(Console.ReadLine());
            double newNum3 = divide;
            Console.WriteLine("Your number / 12.5 is: " + userInput3 / 12.5);
            Console.ReadLine();


            //Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.
            int sweetSpot = 51;
            int low = 50;
            int userInput4;

            Console.WriteLine("Enter another number: ");
            userInput4 = int.Parse(Console.ReadLine());
            bool jackpot = sweetSpot > low;
            Console.WriteLine(jackpot);
            Console.ReadLine();


            //Takes an input from the user, divides it by 7, and prints the remainder to the console.
            int divide2;
            int userInput5;
            divide2 = 7;

            Console.WriteLine("Enter another number: ");
            userInput5 = int.Parse(Console.ReadLine());
            int newNum5 = divide2;
            Console.WriteLine("Your number % 7  is: " + userInput5 % 7);
            Console.ReadLine();


        }
    }
}
