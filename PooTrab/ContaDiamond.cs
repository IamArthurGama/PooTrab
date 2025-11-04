using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTrab
{
    public class ContaDiamond : Conta
    {
        private decimal _tarifa;

        public ContaDiamond(Cliente cliente, Banco banco, string codigoConta, decimal saldoInicial, decimal tarifa)
            : base(cliente, banco, codigoConta, saldoInicial)
        {
            _tarifa = tarifa;
        }

        public ContaDiamond(Cliente cliente, Banco banco, string codigoConta, decimal tarifa)
            : base(cliente, banco, codigoConta)
        {
            _tarifa = tarifa;
        }
        public decimal Tarifa
        {
            get => _tarifa;
            set => _tarifa = value;
        }

        //implementar os metodos ainda
    }
}
