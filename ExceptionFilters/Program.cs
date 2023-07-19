using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace ExceptionFilter
{

    public class InsufficientFundsException : Exception
    {

        public InsufficientFundsException() : base("Insufficient funds")
        {

        }
    }
    public class BankingApp
    {
        private int AccountNumber;
        private double RequestedAmount;
        private double AvailableAmount;


        

        public static void withdraw(int AccountNumber, double RequestedAmount, double AvailableAmount)
        {

            if (RequestedAmount > AvailableAmount)
            {
                throw new InsufficientFundsException();
            }
            else
            {
                Console.WriteLine("Amount can be withdrawn");
            }
        }
        public static void Main(String[] args)
        {

            BankingApp app = new BankingApp();
            Console.WriteLine("Enter Account Number");
            app.AccountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Available Amount");
            app.AvailableAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Requested Amount");
            app.RequestedAmount = double.Parse(Console.ReadLine());

            try
            {
                withdraw(app.AccountNumber, app.RequestedAmount, app.AvailableAmount);
            }
            catch (Exception ex) when(ex.GetType().ToString() == "InsufficientFundsException")
            {
                Console.WriteLine("Sorry you have insufficient funds");
                Console.WriteLine(ex.Message);
            }





        }
    }
}
