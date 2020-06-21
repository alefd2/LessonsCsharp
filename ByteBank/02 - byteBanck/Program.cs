using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___byteBanck
{
    class Program
    {
        static void Main(string[] args)
        {
            contaCorrente contaAlef = new contaCorrente();

            contaAlef.titular = "Alef";

            contaAlef.Sacar(50);

            Console.WriteLine(contaAlef.saldo);
            Console.ReadLine();
        }
    }
}
