using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTrab
{
    abstract class Conta
    {

        //        - cliente: Cliente
        //- banco: Bancol
        //- codigoConta: string
        //- saldo: decimal
        private Cliente _cliente;
        private Banco _banco;
        private string _codigoConta;
        private decimal _saldo;


        public Conta(Cliente cliente, Banco banco, string codigoConta, decimal saldo)
        {
            _cliente = cliente;
            _banco = banco;
            _codigoConta = codigoConta;
            _saldo = saldo;
        }
        public Conta(Cliente cliente, Banco banco, string codigoConta)
        {
            _cliente = cliente;
            _banco = banco;
            _codigoConta = codigoConta;
            _saldo = 0;
        }


    }
}
