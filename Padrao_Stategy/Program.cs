using Padrao_Stategy.Application;
using Padrao_Stategy.Dominio.InterFace;
using Padrao_Stategy.Dominio.repository;
using System;

namespace Padrao_Stategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto iccc = new ICCC();
            CalcularImposto calc = new CalcularImposto();
            Console.WriteLine("Entre com o Orçamento!!");
            var valor = Convert.ToDouble(Console.ReadLine());         

            Console.WriteLine("O  valor é de : " + calc.RealizaCalculoImposto(valor, iss));
            Console.ReadKey();


        }
    }
}
