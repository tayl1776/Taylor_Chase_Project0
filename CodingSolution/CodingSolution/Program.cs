﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingSolution
{

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please place input");
            //string input = Console.ReadLine();
            foreach (string x in args)
            {
                Char[] inputArr = x.ToCharArray();
                int backwards = inputArr.Length - 1;
                bool palondrome = true;
                for (int i = 0; i < backwards; i++)
                {
                    if (Char.IsLetterOrDigit(inputArr[i]) && Char.IsLetterOrDigit(inputArr[backwards]))
                    {
                        if (Char.ToLower(inputArr[i]) != Char.ToLower(inputArr[backwards]))
                        {
                            
                            palondrome = false;
                            i = backwards;
                        }
                        else
                        {
                            backwards--;
                        }
                    }
                    else
                    {
                        if (Char.IsLetterOrDigit(inputArr[i]))
                        {
                            backwards--;
                            i--;
                        }
                    }
                }
                if (palondrome)
                {
                    Console.WriteLine("It is a palondrome");
                }
                else
                {
                    Console.WriteLine("Is not a palondrome");
                }
            }
            Console.ReadKey();
        }
    }
}
