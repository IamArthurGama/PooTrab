using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTrab
{
    public class ContaGold : Conta
    { 
        private decimal _taxaSaque;
        private decimal _taxaTransferencia;
        private decimal _tarifa;

        public ContaGold(Cliente cliente, Banco banco, string codigoConta, decimal saldoInicial,
              decimal taxaSaque, decimal taxaTransferencia, decimal tarifa)
            : base(cliente, banco, codigoConta, saldoInicial)
        {
            _taxaSaque = taxaSaque;
            _taxaTransferencia = taxaTransferencia;
            _tarifa = tarifa;
        }

        
        public ContaGold(Cliente cliente, Banco banco, string codigoConta,
              decimal taxaSaque, decimal taxaTransferencia, decimal tarifa)
            : base(cliente, banco, codigoConta)
        {
            _taxaSaque = taxaSaque;
            _taxaTransferencia = taxaTransferencia;
            _tarifa = tarifa;
        }

       
        public decimal TaxaSaque
        {
            get => _taxaSaque;
            set => _taxaSaque = value;
        }

        public decimal TaxaTransferencia
        {
            get => _taxaTransferencia;
            set => _taxaTransferencia = value;
        }

        public decimal Tarifa
        {
            get => _tarifa;
            set => _tarifa = value;
        }

        //implementar os metodos ainda

    }
}
