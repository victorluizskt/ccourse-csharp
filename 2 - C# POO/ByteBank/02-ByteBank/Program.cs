using System;

namespace _02_ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();

            contaCorrente.Titular = "Victor Luiz";
            Console.WriteLine(contaCorrente.Titular);

            Console.ReadLine(); 
        }
    }
}
