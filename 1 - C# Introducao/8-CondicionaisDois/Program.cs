using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CondicionaisDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("João pode entrar.");
            }
            else
            {
                Console.WriteLine("João não pode entrar.");
            }

            Console.ReadLine();
        }
    }
}
