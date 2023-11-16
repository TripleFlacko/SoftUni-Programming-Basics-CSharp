﻿namespace _05.GenericCountMethodString
{
    public class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            var elementToCompare = Console.ReadLine();
            var count = Count(list, elementToCompare);
            Console.WriteLine(count);
        }
        static int Count<T>(List<T> list, T element) where T : IComparable
        {
            var count = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}