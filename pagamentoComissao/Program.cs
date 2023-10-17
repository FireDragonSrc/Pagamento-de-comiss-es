using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pagamentoComissao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome:");
            string funcionario = Console.ReadLine();
            Console.WriteLine("Qual o preço do produto?");
            float produto = int.Parse(Console.ReadLine());
            float resultado = 5/100f * produto;                  //5/100 X 700
            Console.WriteLine("A sua comissão será de: " + resultado);
            Console.ReadLine();
        }
    }
}
