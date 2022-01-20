using System;

namespace P11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 - Calcula Poupança");
            double valorInvestido = 1000;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 0.036;
                Console.WriteLine($"Após {contadorMes} mês, você terá R${valorInvestido:F2}");
            }
            Console.ReadLine();
        }
    }
}
