namespace _06___ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; } 

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
