using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTrab
{
    public class Cliente
    {   
        private string _nome;
        private string _cpf;
        private string _telefone;
        private string _endereco;

        public string Nome => _nome;
        public string Cpf => _cpf;
        public string Telefone => _telefone;
        public string Endereco => _endereco;

        public Cliente(string nome, string cpf, string telefone, string endereco)
        {
            Verifica.VerificaString(nome);
            Verifica.VerificaCpf(cpf);
            Verifica.VerificaTelefone(telefone);
            Verifica.VerificaString(endereco);
            _nome = nome;
            _cpf = cpf;
            _telefone = telefone;
            _endereco = endereco;
        }

    }
}
