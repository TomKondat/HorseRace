﻿using System;
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
            Console.WriteLine("Enter the number of horse in the race (between 1-10)");
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out var value))
                {
                    if (value > 0 && value <= 10)
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
            Console.WriteLine("Enter race length between 1-50 KM");
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
