using System;

namespace _01_ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente contaCorrenteVictor = new ContaCorrente();
            contaCorrenteVictor.Titular = "Victor Luiz";
            contaCorrenteVictor.Agencia = 863;
            contaCorrenteVictor.Numero = 863145;
            contaCorrenteVictor.Saldo = 100;

            Console.WriteLine($"Conta: {contaCorrenteVictor.Titular}\n" +
                $"Agência: {contaCorrenteVictor.Agencia}\n" +
                $"Número: {contaCorrenteVictor.Numero}\n" +
                $"Saldo: R${contaCorrenteVictor.Saldo}");

            Console.ReadLine();
        }
    }
}
