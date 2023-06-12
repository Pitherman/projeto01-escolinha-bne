using System;

namespace _Teste01

{
    class Program
    {
        static void Main(string[] args)
        {
            ValorFuturo vf = new ValorFuturo();
            Console.WriteLine("\nQual o valor investido?");
            vf.valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a taxa de juros aplicada?");
            vf.taxa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o período, em meses, que pretende manter o valor investido?");
            vf.periodo = Convert.ToInt32(Console.ReadLine());
            vf.tabela();
        }

    }

}