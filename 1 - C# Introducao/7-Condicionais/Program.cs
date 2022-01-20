using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if(idadeJoao >= 18 )
            {
                Console.WriteLine("É maior que 18 anos.");
            } 
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas esta acompanhado pode entrar");
                }
                Console.WriteLine("João não possui mais de 18 anos");
            }

            Console.ReadLine();
        }
    }
}
