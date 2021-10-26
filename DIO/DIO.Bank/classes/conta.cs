using System;

namespace DIO.Bank
{
    public class Conta
    {
        //PROPRIEDADES
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }


        public Conta(TipoConta tipoConta, double Saldo, double Credito, string Nome, double saldo, double credito, string nome)           //CONSTRUTOR
        {
            this.TipoConta = tipoConta;
            this.Saldo = Saldo;
            this.Credito = Credito;
            this.Nome = Nome;
        }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            TipoConta = tipoConta;
            Saldo = saldo;
            Credito = credito;
            Nome = nome;
        }

        public bool Sacar(double valorSaque)      //METODO DE SACAR
        {
            //Validação de saldo suficiente
            if (this.Saldo - valorSaque < (this.Credito *-1)){
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
                this.Saldo -= valorSaque;

                Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            

            return true;
        }
        public void Depositar(double valorDeposito)     //METODO DE DEPOSITO
        {
            this.Saldo += valorDeposito;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this,Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)     //METODO DE TRANSFERENCIA
        {
            if (this.Sacar(valorTransferencia))
            {contaDestino.Depositar(valorTransferencia);}
        }

        
        //METODO PRA REPRESENTAR NO CONSOLE 
        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " ! ";
            retorno += "Nome " + this.Nome + " ! ";
            retorno += "Saldo " + this.Saldo + " ! ";
            retorno += "Crédito " + this.Credito ;
            return retorno;

        }

        
    }
}