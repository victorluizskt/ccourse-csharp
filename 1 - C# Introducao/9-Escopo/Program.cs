using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            IR();
            Console.WriteLine("Executando projeto 8");

            int idadeJoao = 16;
            bool acompanhado = false;

            string mensagemAdicional;

            if (acompanhado)
            {
                mensagemAdicional = "João está acompanhado";
            } 
            else
            {
                mensagemAdicional = "João não está acompanhado.";
            }

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("João pode entrar e " + mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João não pode entrar " + mensagemAdicional);
            }

            Console.ReadLine();
        }

        public static void IR()
        {
            double salario = 2300;
            if(salario >= 1900 && salario < 2800)
            {
                Console.WriteLine($"IR = 7.5%, seu salário é: R${(salario * 0.075) - salario + 142}");
            } else if(salario >= 2801 && salario < 3751)
            {
                Console.WriteLine($"IR = 15%, seu salário é: R${(salario * 0.15) - salario + 350}");
            } else if(salario >= 3751 && salario < 4664)
            {
                Console.WriteLine($"IR = 22.5%, seu salário é: R${(salario * 0.225) - salario + 636}");
            }
        }
    }
}
