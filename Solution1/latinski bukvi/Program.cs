﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latinski_bukvi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; i < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.WriteLine($"{(char)'a'}{(char)'a'+j}{(char)('a'+k)}");
                    }
                }
            }
        }
    }
}
