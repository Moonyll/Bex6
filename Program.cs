﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bex6
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] months = new string[] {"Janvier","Février","Mars","Avril","Mai","Juin","Juillet","Août","Septembre","Octobre","Novembre","Décembre"};
            
            foreach (string month in months)
            {
             Console.WriteLine($"{month}");
            }
        }
    }
}
