using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            // O int é uma variavel de 32 bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // O long é uma variavel de 64 bits
            long idade = 130000000000000;
            Console.WriteLine(idade);

            // Short é variavel de 16 bits
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80F;
            Console.WriteLine((altura + altura));

            Console.ReadLine();
        }
    }
}
