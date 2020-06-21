using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando aplicação");

            double valorInvest = 1000;
            double txInves = 0.0036;



            for(int ano = 1; ano <= 5; ano++)
            {

                Console.WriteLine("No ano " + ano + " Com a taxa de investimento a " + txInves + " ao mês");
                Console.WriteLine("");
                for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {   

                    //valorInvest *= 1.0036; // Forma simples de calculo com o fator estático da tx de invest
                    valorInvest  = valorInvest + (valorInvest * txInves); // Forma dimanima de obter os dados da taxa.
                    Console.WriteLine("Valor o retorno do investimento no mês " + contadorMes + " é de R$" + valorInvest );
                }

            txInves += 0.0010;
            Console.WriteLine("");

            }



            Console.WriteLine("Execução da aplicação terminada! Clicar enter para finalizar . . .");
            Console.ReadLine();

        }
    }
}
