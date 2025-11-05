using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTrab
{
    public class ContaGold : Conta
    {
        private decimal _taxaSaque = 2;
        private decimal _taxaTransferencia = 4;

        public ContaGold(Cliente cliente, Banco banco, string codigoConta, decimal saldo)
            : base(cliente, banco, codigoConta, saldo)
        {
        }

        public ContaGold(Cliente cliente, Banco banco, string codigoConta)
            : base(cliente, banco, codigoConta)
        {
        }
        public decimal TaxaSaque
        {
            get => _taxaSaque;
            private set => _taxaSaque = value;
        }

        public decimal TaxaTransferencia
        {
            get => _taxaTransferencia;
            private set => _taxaTransferencia = value;
        }       

        public override string Sacar(decimal value)
        {
            decimal valorTotal = value + (value * _taxaSaque);

            if (valorTotal > Saldo)
                throw new Exception("Saldo insuficiente.");

            Saldo -= valorTotal;
            return $"Saque de {value:C2} realizado com taxa de {_taxaSaque:P}. Saldo atual: {Saldo:C2}";
        }

        public override string Transferir(Conta contaRecebe, decimal value)
        {
            decimal valorTotal = value + (value * _taxaTransferencia);

            if (valorTotal > Saldo)
                throw new Exception("Saldo insuficiente para transferência com taxa.");

            Saldo -= valorTotal;
            contaRecebe.Depositar(value);

            return $"Transferência de {value:C2} realizada com taxa de {_taxaTransferencia:P}. " +
                   $"Saldo atual: {Saldo:C2}";
        }
        
    }

}

