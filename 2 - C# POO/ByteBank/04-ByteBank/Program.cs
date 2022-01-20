using System;

namespace _04_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrenteVictor = new ContaCorrente();
            contaCorrenteVictor.Titular = "Victor Luiz";
            contaCorrenteVictor.Numero = 863;
            contaCorrenteVictor.Agencia = 863452;
            contaCorrenteVictor.Saldo = 1000;

            Console.WriteLine(contaCorrenteVictor.Sacar(100));
            Console.WriteLine(contaCorrenteVictor.Saldo);

            contaCorrenteVictor.Depositar(4000);
            Console.WriteLine(contaCorrenteVictor.Saldo);

            ContaCorrente contaCorrenteThais = new ContaCorrente();
            contaCorrenteThais.Titular = "Thais N.";
            contaCorrenteThais.Numero = 863;
            contaCorrenteThais.Agencia = 863452;
            contaCorrenteThais.Saldo = 1000;

            contaCorrenteVictor.Transferir(200, contaCorrenteThais);
            Console.WriteLine("Saldo do Victor: " + contaCorrenteVictor.Saldo);
            Console.WriteLine("Saldo do Thais: " + contaCorrenteThais.Saldo);
            Console.ReadLine();
        }
    }
}
