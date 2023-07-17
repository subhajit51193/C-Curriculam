using System;

namespace Assignment1
{
    public class Assignment1
    {

        public static void Main(String[] args)
        {
            //declaring varibale;
            int num;

            //taking input from user
            Console.WriteLine("Please enter any number");
            num = Convert.ToInt32(Console.ReadLine());

            //checking conditions

            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("The number "+num+" is devisible by both 3 and 5");
            }
            else if (num % 3 == 0 || num % 5 == 0)
            {
                Console.WriteLine("The number " + num + " is devisible by  3 or 5");

            }
            else
            {
                Console.WriteLine("The number "+num+" is not devisible both 3and 5");
            }

        }
    }
}
