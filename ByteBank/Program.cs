using System;
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
                ContaCorrente conta = new ContaCorrente(222, 4555);
                conta.Depositar(10000);
                conta.Sacar(-789);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);

            }

            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
          
            

           
         

            Console.ReadLine();
        }
    }
}
