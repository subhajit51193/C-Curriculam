using System;

namespace Assignment1
{

    public class Assignment1
    {

        public static void Main(String[] args)
        {

            //Question number 1 Basic Arithmetic operations
            //declaring variables
            int Number1;
            int Number2;
            int Result1;
            int Result2;
            int Result3;
            int Result4;

            //taking first input
            Console.WriteLine("please enter the Number1");

            //after converting to int storing the input
            Number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the Number2");

            //after converting to int storing the input
            Number2 = Convert.ToInt32(Console.ReadLine());

            //addition
            Result1 = Number1 + Number2;

            //display result for addition
            Console.WriteLine("Sum of two Numbers:" + Result1.ToString());
            Console.ReadLine();

            //subtraction
            Result2 = Number1 - Number2;

            //display result for subtraction
            Console.WriteLine("Subtraction of two Numbers:" + Result2.ToString());
            Console.ReadLine();

            //Multiplication
            Result3 = Number1 * Number2;

            //display result for subtraction
            Console.WriteLine("Multiplication of two Numbers:" + Result3.ToString());
            Console.ReadLine();

            //Division
            Result4 = Number1 / Number2;

            //display result for division
            Console.WriteLine("Multiplication of two Numbers:" + Result4.ToString());
            Console.ReadLine();

            Console.WriteLine("ENd of Question number 1.");

        }
    }
}

