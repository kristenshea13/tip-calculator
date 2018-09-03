using System;

namespace tip_calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tip Calculator");

            //ask for check subtotal then convert to decimal
            Console.Write("Enter subtotal:  ");
            decimal subtotal = decimal.Parse(Console.ReadLine());

            //prompt for percentage tip user would like to leave and convert to decimal
            Console.Write("What percentage would you like to tip?  ");
            decimal tip = decimal.Parse(Console.ReadLine());

            //multiply check subtotal by percent, already converted to decimal in method below
            decimal tipAmount = subtotal * PercentTip(tip);
            
            //convert tipAmount to a string formatted as currency
            string tipAmountString = $"{tipAmount:C}";

            //print tip amount to console
            Console.WriteLine("You should leave {0}.", tipAmountString);

            Console.ReadLine();

        }

        /// <summary>
        /// method to convert percent entered above to decimal to figure out tip
        /// </summary>
        /// <param name="tip"></param>
        /// <returns>percentage as a decimal, ex 25 will return as .25</returns>
        private static decimal PercentTip(decimal tip)
        {
            return tip / 100;
        }


    }
}
