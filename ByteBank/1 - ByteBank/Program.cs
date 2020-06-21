using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            contaCorrente contaRebecca = new contaCorrente();

            contaRebecca.titular = "Rebecca";
            contaRebecca.agencia = 863;
            contaRebecca.numero = 863146;
            contaRebecca.saldo = 1200.00;

            Console.WriteLine("Conta titular: " + contaRebecca.titular);
            Console.WriteLine(" Agencia: " + contaRebecca.agencia);
            Console.WriteLine("Numero da conta: " + contaRebecca.numero);
            Console.WriteLine("Saldo: " + contaRebecca.saldo);

            Console.ReadLine();
        }
    }
}
