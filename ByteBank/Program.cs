﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(-14,5398);
            

            Console.WriteLine(conta.Agencia);
         

            Console.ReadLine();
        }
    }
}