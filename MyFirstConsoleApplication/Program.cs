

namespace MyFirstConsoleApplication
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Emma";
            string location = "Brazil";
            DateTime thisDate = new DateTime(2023, 4, 20);

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from {location}");
            Console.WriteLine(thisDate.ToString("d"));

            DateTime currentDate = DateTime.Now;
            DateTime christmasDate = new DateTime(2023, 12, 25); 

            TimeSpan diferenca = christmasDate - currentDate;
            int daysUntilChristmas = (int)diferenca.TotalDays;

            Console.WriteLine($"Days until Christmas {daysUntilChristmas}");
       
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("\nWidth of the window: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("\nHeight of the window: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square meters");

            Console.ReadKey();
        
            


        }
    }

    
}