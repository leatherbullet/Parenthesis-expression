﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = '(';
            char secondSymbol = ')';
            int countFirstSymbol = 0;
            int depth = 0;
            string userInput;

            Console.WriteLine($"вводите символы {firstSymbol} или {secondSymbol}");
            userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++) 
            {
                if (userInput[i] == firstSymbol)
                {
                    countFirstSymbol++;
                    
                    if(countFirstSymbol > depth)
                    {
                        depth = countFirstSymbol
                    }
                }
                else if (userInput[i] == secondSymbol) 
                {
                    countFirstSymbol--;
                    
                    if(countFirstSymbol < 0)
                    {
                        break;
                    }
                }
            }

            if (countFirstSymbol == 0)
            {
                Console.WriteLine($"ввод корректный глубина:{depth}");
            }
            else
            {
                Console.WriteLine($"ввод:{userInput} некорректный");
            }
        }
    }
}
