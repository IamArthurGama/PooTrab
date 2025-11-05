using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTrab
{
    public class ContaDiamond : Conta
    {

        public ContaDiamond(Cliente cliente, Banco banco, string codigoConta, decimal saldo)
            : base(cliente, banco, codigoConta, saldo)
        {
        }

        public ContaDiamond(Cliente cliente, Banco banco, string codigoConta)
            : base(cliente, banco, codigoConta)
        {
        }

    }
}
