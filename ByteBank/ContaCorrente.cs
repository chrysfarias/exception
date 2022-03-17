﻿
using System;



namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

      
        public int Numero { get; }
        public int Agencia { get; }




        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                ArgumentException excecao = new ArgumentException("O argumento agência  deve ser maior que 0");
                throw excecao;
            }

            if (numero <= 0)
            {
                ArgumentException excecao = new ArgumentException("O argumento numero  deve ser maior que 0");
                throw excecao;
            }

            Agencia = agencia;
            Numero = numero;

            
            try
            {
                TaxaOperacao = 30 / TotalDeContasCriadas;
            }

            catch(DivideByZeroException)
            {
                Console.WriteLine("Não é possivel fazer uma divisão por 0");
            }
           
            TotalDeContasCriadas++;
        }



       

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
