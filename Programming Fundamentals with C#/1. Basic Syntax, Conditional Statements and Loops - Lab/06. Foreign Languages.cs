﻿using System;

namespace _06.Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            switch (input)
            {
                case "USA":
                case "England": Console.WriteLine("English"); break;
                case "Spain":
                case "Argentina":
                case "Mexico": Console.WriteLine("Spanish"); break;
                default: Console.WriteLine("unknown"); break;
            }
        }
    }
}