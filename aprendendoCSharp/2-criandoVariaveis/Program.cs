using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_criandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executanto projeto 2");

            int idade = 23;
            double salario = 1111.1;
            string data = "27/06/1996";
            float altura = 1.72f;

            int valorAtual = (int)salario; //cast mudança de double para int


            idade = idade + 1;

            Console.WriteLine("Meu aniversário é dia " + data + ". Dps desse dia eu terei " + idade + ".");
            Console.WriteLine("Eu ganhava de salário " + salario + ". Hoje eu ganho " + valorAtual + " E minha altura é " + altura);
             
            Console.WriteLine("Execução terminada! Tecle enter para sair . . . !");
            Console.ReadLine();
        }
    }
}
