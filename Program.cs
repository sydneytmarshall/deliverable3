using System;
namespace Deliverable3;
class Program
{
    static void Main(string[] args)
    {
        try
        { 
        Console.Write("Enter an integer between 1 and 100: ");
        int input = int.Parse(Console.ReadLine());

            if (input >= 0 && input <= 100)
            {
                Console.Write("Specify the series type: Even or Odd?");
                string series = Console.ReadLine();

                if (series == "Odd")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are");
                    for (int i = 1; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
                else if (series == "Even")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are");
                    for (int i = 2; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Please, try again and specify the series type: \"Even\" or \"Odd\"");
                }
            }
         
        }
        catch
        {
            Console.WriteLine("Please, enter an integer value");
        }
    }
}
