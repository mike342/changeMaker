using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changeMaker
{
    class Program
    {
        static void changeMaker(double amount)
        {
            // printing the amount or (input) first
            Console.WriteLine(amount);
            // declering the variables
            var quarters = 0;
            var dimes = 0;
            var nickles = 0;
            var pennies = 0;
            //doing our while loop for the quarter

            while (amount > .25)
            {
                quarters++;
                amount -= .25;
            }//while loop for the dime
            while (amount > .10)
            {
                dimes++;
                amount -= .10;
            }//while loop for the nickles
            while (amount > .05)
            {
                nickles++;
                amount -= .05;
            }//while loop for the pennie
            while (amount > .01)
            {
                pennies++;
                amount -= .01;

            }//telling the comp. to print out our quarter,dime,nickles and penny value each on a new line
            Console.WriteLine(quarters);
            Console.WriteLine(dimes);
            Console.WriteLine(nickles);
            Console.WriteLine(pennies);


        }
        static void Main(string[] args)
        {
            changeMaker(3.18);
            changeMaker(0.99);
            changeMaker(12.93);
            Console.ReadKey();

        }
    }
}
