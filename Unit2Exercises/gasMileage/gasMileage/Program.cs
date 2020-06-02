using System;

namespace gasMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many miles driven.");
            string userInput1 = Console.ReadLine();
            int miles = int.Parse(userInput1);
            Console.WriteLine("Please enter how many gallons of gas used.");
            string userinput2 = Console.ReadLine();
            int gas = int.Parse(userinput2);
            int mileage = miles / gas;
            string mpg = mileage.ToString();
            Console.WriteLine("Your gas mileage is " + mpg + " mpg.");
        }
    }
}
