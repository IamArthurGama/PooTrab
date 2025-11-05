using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTrab
{
    public class ContaFree : Conta
    {
        private decimal _taxaSaque = 10m;
        private decimal _taxaTransferencia = 5m;
        public ContaFree(Cliente cliente, Banco banco, string codigoConta)
            : base(cliente, banco, codigoConta)

        {

        }
        public ContaFree(Cliente cliente, Banco banco, string codigoConta, decimal saldo)
        : base(cliente, banco, codigoConta, saldo)
        {

        }

        public decimal TaxaSaque { get => _taxaSaque; private set => _taxaSaque = value; }
        public decimal TaxaTransferencia { get => _taxaTransferencia; private set => _taxaTransferencia = value; }

        public override string Sacar(decimal value)
        {
            Verifica.VerificaDecimal(value);
            decimal valueTaxado = value + TaxaSaque;

            if (!(valueTaxado > Saldo))
            {
                Saldo -= valueTaxado;
                return $"O valor do saque foi de: {value:C2} com uma taxa de {TaxaSaque:C2}. O seu saldo atual é de {Saldo}";
            }
            else
            {
                throw new ArgumentException("O valor do saque não poderá exceder o valor do saldo.");
            }
        }

        public override string Transferir(Conta contaRecebe, decimal value)
        {
            Verifica.VerificaDecimal(value);
            decimal valueTaxado = value + TaxaTransferencia;

            Saldo -= valueTaxado;
            contaRecebe.Depositar(value);
            return $"Deposito para a conta {contaRecebe.CodigoConta} com o valor de {value} e com uma taxa de {TaxaTransferencia} foi efetuado com sucesso, seu saldo atual é de {this.Saldo}";

        }


    }
}
