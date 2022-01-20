namespace _08___ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        public int Agencia { get; set; }
        public int Numero { 
            get
            {
                return Numero;
            }
            set 
            { 
                if(value < 0)
                {
                    return;
                }

                Numero = value;
            }
        }
        public double Saldo { get; set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if(Saldo < valor)
                return false;   

            Saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            if(valor > 0)
                Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (Saldo < valor)
                return false;

            Saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }

}
