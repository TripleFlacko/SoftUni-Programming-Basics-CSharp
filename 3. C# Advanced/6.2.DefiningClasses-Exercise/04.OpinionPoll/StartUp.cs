﻿using System;
using DefiningClasses;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                var name = input[0];
                var age = int.Parse(input[1]);

                var person = new Person(name, age);
                family.AddMember(person);
            }

            var sordedList = family.People.Where(person => person.Age > 30).OrderBy(x=>x.Name);
            foreach (var person in sordedList)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}