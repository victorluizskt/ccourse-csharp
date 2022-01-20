using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
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

            ContaCorrente contaCorrenteThais = new ContaCorrente();
            contaCorrenteThais.Titular = "Thais N.";
            contaCorrenteThais.Numero = 863;
            contaCorrenteThais.Agencia = 863452;
            contaCorrenteThais.Saldo = 1000;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaCorrenteVictor == contaCorrenteThais));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));
            contaCorrenteVictor = contaCorrenteThais;
            Console.WriteLine(contaCorrenteVictor == contaCorrenteThais);

            contaCorrenteThais.Saldo = 300;
            Console.WriteLine(contaCorrenteThais.Saldo);
            Console.WriteLine(contaCorrenteVictor.Saldo);

            Console.ReadLine();
        }
    }
}
