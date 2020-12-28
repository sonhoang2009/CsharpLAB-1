﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet2._14
{
    class Program
    {
        static void Main(string[] args)
        {
            string custName;
            double loanAmount;
            float interest = 0.09F;
            double interestAmount = 0;
            double totalAmount = 0;
            Console.Write("Enter the name of the customer : ");
            custName = Console.ReadLine();
            Console.Write("Enter loan amount: ");
            loanAmount = Convert.ToDouble(Console.ReadLine());
            interestAmount = loanAmount * interest;
            totalAmount = loanAmount + interestAmount;
            Console.WriteLine("\nCustomer Name :{0}", custName);
            Console.WriteLine("Loanamount: ${0:#,###.#0} \nInterest rate : {1:0#%} \nInterestAmount : ${2:#,###.#0}", loanAmount, interest, interestAmount);
            Console.WriteLine("Total amount to be paid : ${0:#,###.#0}", totalAmount);

            Console.ReadKey();
        }
    }
}
