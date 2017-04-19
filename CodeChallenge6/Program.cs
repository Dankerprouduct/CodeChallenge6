using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge6
{
    class Program
    {
        // created by David Fitsgerald
        // Decimal to Binary Converter
        // 4/17/2017

        static void Main(string[] args)
        {

            while (true) //  <-- keeps the program from clossing 
            {
                Console.WriteLine("Please enter a number (integer only)");
                int num = Convert.ToInt32(Console.ReadLine());  // takes in the user's input as an integer

                string binary = ""; // initializes a string called binary

                while (num > 0) // continues to loop until the number that the user input is 0
                {
                    if (num % 2 == 0) // checks to seee if the remainder of the number divided by 2 is 0
                    {
                        binary += "0"; // if it is, add 0 to binary
                    }
                    else
                    { // if its not, add 1 to binary
                        binary += "1";
                    }
                    // divide the string by 2 and set it equal to itself and repeat the process again until num is 0
                    num = num / 2;
                }

                Console.WriteLine(ReverseString(binary));  // Calls reverse string to get the binary in the correct format

                Console.ReadKey(); // waits for user input to restart the whole program again
            } 
        }

        static string ReverseString(string str) // takes string as a parameter and returns a string as the return type
        {
            char[] charArray = str.ToArray(); // converts the string into an array
            Array.Reverse(charArray); // reverses the array 
            return new string(charArray); // returns the array as a string
        }
    }
}
