﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectForGit
{
    internal class Program
    {
        public void Add()
        {
            int a = 10, b = 20, c;
            c = a + b;
            Console.WriteLine("Add=" + c);
        }
        public void Sub()
        {
            int a = 10, b = 20, c;
            c = a - b;
            Console.WriteLine("Sub=" , c1);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add();
            Console.ReadLine();
        }
    }
}
