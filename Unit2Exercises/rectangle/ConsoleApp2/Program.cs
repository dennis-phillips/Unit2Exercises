using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the rectangle");
            string userInput1 = Console.ReadLine();
            int length = int.Parse(userInput1);
            Console.WriteLine("Please enter the width of the rectangle");
            string userinput2 = Console.ReadLine();
            int width = int.Parse(userinput2);
            int area = length * width;
            string areaString = area.ToString();
            Console.WriteLine("The area of the rectangle is " + areaString);
        }
    }
}
