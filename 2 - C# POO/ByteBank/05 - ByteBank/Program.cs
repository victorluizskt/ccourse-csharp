using System;

namespace _05___ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Cliente victor = new Cliente();
            // victor.Nome = "Victor";
            // victor.Profissao = "Analista de Sistemas Jr";
            // victor.Cpf = "12345678";

            ContaCorrente contaCorrente = new ContaCorrente();
            // contaCorrente.Titular = victor;
            contaCorrente.Saldo = 500;
            contaCorrente.Agencia = 563;
            contaCorrente.Numero = 5634527;

            contaCorrente.Titular = new Cliente();
            // Irá refletir no valor original, porque nosso objeto é o mesmo.
            contaCorrente.Titular.Nome = "Victor Luiz";
            contaCorrente.Titular.Cpf = "12345678";
            contaCorrente.Titular.Profissao = "Analista de Sistemas Jr";

            // Console.WriteLine(victor.Nome);
            Console.WriteLine(contaCorrente.Titular.Nome);

            Console.ReadLine();
        }
    }
}
