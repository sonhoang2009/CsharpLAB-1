﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet4
{
    class Program
    {
        static void Main(string[] args)
        {
            var boolTest = true;
            var byteTest = 19;
            var intTest = 140000;
            var stringTest = "David";
            var floatTest = 14.5f;

            Console.WriteLine("boolTest = {0}", boolTest);
            Console.WriteLine("byteTest = " + byteTest);
            Console.WriteLine("intTest = " + intTest);
            Console.WriteLine("floatTest = " + floatTest);
            Console.WriteLine("stringTesr = " + stringTest);

            Console.ReadKey();
        }
    }
}
