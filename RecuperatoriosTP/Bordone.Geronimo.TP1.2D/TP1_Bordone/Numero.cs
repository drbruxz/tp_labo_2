using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Bordone
{
    public class Numero
    {
        private double numero;
        public string setNumero
        { 
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        internal Numero()
        {
            this.numero = 0;
        }

        public double ValidarNumero(string strNumero)
        {
            double returnValue;
            if(!(double.TryParse(strNumero,out returnValue)))
            {
                returnValue = 0;
            }

            return returnValue;
        }
#region Operacion y Conversion
        public string BinarioDecimal(string binario)
        {
            string returnValue = "Valor invalido";
            bool checkIfBin = true;
            int valueParse;
            foreach (var c in binario)
            {
                if (c != '0' && c != '1')
                {
                    checkIfBin = false;
                    break;
                }
            }
            if (checkIfBin) { 
                valueParse = Convert.ToInt32(binario,2);
                returnValue = valueParse.ToString();
            }
            return returnValue;
        }
        
        public string DecimalBinario(string numero)
        {
            string returnValue = "Valor invalido";
            int intToParse;

            if(int.TryParse(numero, out intToParse))
            {
                returnValue = Convert.ToString(intToParse,2);
            }
            return returnValue;
        }
        
        string DecimalBinario(double numero)
        {
            string returnValue = "Valor invalido";
            returnValue = DecimalBinario(numero.ToString());
            return returnValue;
        }
        public static double operator +(Numero num1, Numero num2)
        {
            Numero numReturn = new Numero();
            numReturn.numero = num1.numero + num2.numero;
            return numReturn.numero;
        }

        public static double operator -(Numero num1, Numero num2)
        {
            Numero numReturn = new Numero();
            numReturn.numero = num1.numero - num2.numero;
            return numReturn.numero;
        }

        public static double operator *(Numero num1, Numero num2)
        {
            Numero numReturn = new Numero();
            numReturn.numero = num1.numero * num2.numero;
            return numReturn.numero;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            Numero numReturn = new Numero();
            if(num2.numero != 0) { 
                numReturn.numero = num1.numero / num2.numero;
            }
            else
            {
                numReturn.numero = double.MinValue;
            }
            return numReturn.numero;
        }
    }
#endregion


}
