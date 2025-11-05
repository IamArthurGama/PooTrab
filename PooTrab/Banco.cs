using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTrab
{
    public class Banco
    {
        //Atributos
        private string _nome;
        private string _codigoBanco;
        private string _cnpj;

        //Prop de leitura
        public string Nome
        {
            get { return _nome; }
        }
        public string CodigoBanco => _codigoBanco;// Prop de leitura simplificada com arrow "=>" ambas significam que apenas o get é publico
        public string Cnpj => _cnpj;

        //Construtor
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
