using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTrab
{
    public class Verifica
    {
        public static void VerificaString(string value)
        {
           if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException($"O valor {value} está invalido, ele deve ser do tipo string!");
           }
        }

        public static void VerificaDecimalCriacao(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"O valor {value} é inválido para criação da conta. O saldo inicial não pode ser negativo.");
            }
        }
        public static void VerificaDecimal(Decimal value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException($"O valor {value} está invalido, ele deve ser do tipo decimal!");
            }
        }

        public static void VerificaCpf(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O CPF não pode ser nulo ou vazio.");
            }

            string cpfLimpo = value.Trim().Replace(".", "").Replace("-", "");

            if (cpfLimpo.Length != 11)
            {
                throw new ArgumentException("O CPF deve conter 11 dígitos.");
            }
        }
        public static void VerificaCnpj(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O CNPJ não pode ser nulo ou vazio.");
            }

            string cnpjLimpo = value.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

            // 3. Verifica o tamanho
            if (cnpjLimpo.Length != 14)
            {
                throw new ArgumentException("O CNPJ deve conter 14 dígitos.");
            }

            if (!cnpjLimpo.All(char.IsDigit))// o ALL pega toda a string, que no caso é o cnpjLimpo, o char quebra a string e caracteres e o IsDigit verifica se é número
                throw new ArgumentException("O CNPJ deve conter apenas números.");
        }

        public static void VerificaTelefone(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O Telefone não pode ser nulo ou vazio.");
            }

            string telLimpo = value.Trim().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            if (!telLimpo.All(char.IsDigit))
                throw new ArgumentException("O telefone deve conter apenas números.");

            if (telLimpo.Length < 8)
                throw new ArgumentException("O telefone deve conter pelo menos 8 dígitos.");
        }

        public static void VerificaCodBanco(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("O código do banco não pode ser nulo ou vazio.");
            }
            if (value.Trim().Length != 3)// Trim retira o espaços em branco do começo e do fim da string
            {
                throw new ArgumentException("O código do banco deve conter exatamente 3 dígitos.");
            }
            if (!value.Trim().All(char.IsDigit))
            {
                throw new ArgumentException("O código do banco deve conter apenas números.");
            }
        }
    }
}
