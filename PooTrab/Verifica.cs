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
            if (value < 0 || value == null)
            {
                throw new ArgumentException($"O valor {value} está invalido, ele deve ser do tipo decimal!");
            }
        }
    }
}
