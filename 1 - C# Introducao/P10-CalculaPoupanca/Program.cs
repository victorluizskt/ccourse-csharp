using System;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double valorInvestido = 10000;
            int cont = 1;
            while(cont <= 12)
            {
                // 0.36% = 0.0036
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine($"Após {cont} mês, você terá R${valorInvestido:F2}");
                cont++;
            }

            Console.ReadLine();
        }
    }
}
