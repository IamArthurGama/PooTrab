using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTrab
{
    public abstract class Conta
    {
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

        public Cliente Cliente 
        { 
            get => _cliente; 
            private set => _cliente = value; 
        }

        public Banco Banco 
        { 
            get => _banco;
            private set => _banco = value; 
        }

        public string CodigoConta
        {
            get => _codigoConta;
            set => _codigoConta = value;
        }

        public decimal Saldo
        {
            get => _saldo;  
            private set => _saldo = value;
        }

        public string Sacar(decimal value)
        {
            if (!(value > _saldo))
            {
                _saldo -= value;
                return $"O valor do saque foi de: {value:C2}, O seu saldo atual é de {_saldo}";
            }
            else
            {
                throw new ArgumentException("O valor do saque não poderá exceder o valor do saldo.");
            }

            
        }

        public void Transferir()
        {

        }

        public void Depositar()
        {

        }

        public void VerificarSaldo()
        {

        }


    }
}
