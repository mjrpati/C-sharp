using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class MySpace
    {
        static void Main(string[] args)
        

        {
            string nome;
            double salariofixo, vendas, m;

            nome = Console.ReadLine();
            salariofixo = double.Parse(Console.ReadLine());
            vendas = double.Parse(Console.ReadLine());

            m = vendas * 15 /100 + salariofixo;

            Console.WriteLine("TOTAL = R$ " + m.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
    
}

