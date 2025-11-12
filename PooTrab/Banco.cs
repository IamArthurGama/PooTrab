using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTrab
{
    public class Banco
    {
        private string _nome;
        private string _codigoBanco;
        private string _cnpj;

        public string Nome
        {
            get { return _nome; }
        }
        public string CodigoBanco => _codigoBanco;
        public string Cnpj => _cnpj;

        public Banco(string nome, string codigoBanco, string cnpj)
        {
            Verifica.VerificaCodBanco(codigoBanco);
            Verifica.VerificaCnpj(cnpj);
            Verifica.VerificaString(nome);
            _nome = nome;
            _codigoBanco = codigoBanco;
            _cnpj = cnpj;
        }
    }
}
