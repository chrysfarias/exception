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

            try 
            { 
                ContaCorrente conta = new ContaCorrente(0,0);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            
            }
            catch (Exception ex)    
            { 
                Console.WriteLine(ex.Message);
            
            }
          
            

           
         

            Console.ReadLine();
        }
    }
}
