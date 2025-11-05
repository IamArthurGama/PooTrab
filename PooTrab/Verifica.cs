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
           if (string.IsNullOrEmpty(value)) {
                throw new ArgumentException($"O valor {value} está invalido, ele deve ser do tipo string!");
           }
        }

        public static void VerificaDecimal(Decimal value)
        {
            if (value < 0)
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
        }

        public static void VerificaTelefone(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O Telefone não pode ser nulo ou vazio.");
            }

            string telLimpo = value.Trim().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            foreach (char c in telLimpo)
            {
                if (!char.IsDigit(c))
                {
                    throw new ArgumentException("O telefone deve conter apenas números.");
                }
            }
        }
    }
}
