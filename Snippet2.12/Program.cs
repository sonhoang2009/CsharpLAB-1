﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, result;
            number = 5;
            result = 100 * number;

            Console.WriteLine("Resuilt is {0} when 100 is multiplied by {1}", result, number);

            result = 150 / number;
            Console.WriteLine("Resuilt is {0} when 150 is multiplied by {1}", result, number);

            Console.ReadKey();
        }
    }
}
