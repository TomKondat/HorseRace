using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRace.Validators
{
    public class ValidateNumbers
    {

        public static int ValidateHorseNumber()
        {
            Console.WriteLine("Enter horse number between 1-15");
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out var value))
                {
                    if (value > 0 && value <= 15)
                    {
                        Console.Clear();
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("Input is out of range");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }

        public static int ValidateDotsToWin()
        {
            Console.WriteLine("Enter race length between 1-50");
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out var value))
                {
                    if (value > 0 && value <= 50)
                    {
                        Console.Clear();
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("Input is out of range");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
