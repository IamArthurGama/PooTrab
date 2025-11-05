using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTrab
{
    public class Cliente
    {   
        // Atributos
        private string _nome;
        private string _cpf;
        private string _telefone;
        private string _endereco;

        // Props
        public string nome => _nome;
        public string cpf => _cpf;
        public string telefone => _telefone;
        public string endereco => _endereco;

        // Constructor
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

        public string Nome { get => _nome; private set=> _nome = value; }
    }
}
