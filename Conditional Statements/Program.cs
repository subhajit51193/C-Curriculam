using System;

namespace Assignment1
{
    public class Assignment1
    {

        public static void Main(String[] args)
        {

            //declaring variable
            int num;
            Console.WriteLine("Please Enter number");

            //converting to int
            num = Convert.ToInt32(Console.ReadLine());

            //checking conditions

            if (num < 0)
            {
                Console.WriteLine("The number " + num + " is negetive");
            }
            else if(num > 0)
            {
                Console.WriteLine("The number " + num + " is postive");

            }
            else
            {
                Console.WriteLine("The number " + num + " is 0");

            }
            Console.ReadLine();

        }
    }
}


