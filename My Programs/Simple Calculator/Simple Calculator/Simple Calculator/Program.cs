using System;

namespace My_Awesome_Program
{
    class Program
    {

        static void Main(string[] args)
        {
            //Variables
            int num01;
            int num02;
            Console.Title = "Simple Calculator";


            //Main Function
            Console.Write("Input a Number: ");
            num01 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a second number: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            //Result
            int result = num01 + num02;
            Console.WriteLine("The result is " + result);

            // Wait before closing
            Console.ReadKey();
        }
    }
}
