using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 criando variaveis ponto flutuante.");

            double salario = 1200.70;
            Console.WriteLine(salario);

            double idade = 15.00 / 2;
            Console.WriteLine(idade.ToString("F2"));

            idade = 5 / 3;
            Console.WriteLine($"5 / 3 = {idade}");

            idade = 5.0 / 3;
            Console.WriteLine($"5 / 3 = {idade}");

            Console.ReadLine();
        }
    }
}
