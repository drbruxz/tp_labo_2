using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
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

        public  Numero()
        {
            this.numero = 0;
        }

       public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero (string numero)
        {
            this.setNumero = numero;
        }

        /// <summary>
        /// Valida que una string pueda ser parseada a un entero. Caso contrario retorna 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarNumero(string strNumero)
        {
            double returnValue;
            if(!(double.TryParse(strNumero,out returnValue)))
            {
                returnValue = 0;
            }
            return returnValue;
        }

        #region Operacion y Conversion
        /// <summary>
        /// Convierte de Binario a Decimal un string.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
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
                valueParse = Math.Abs(Convert.ToInt32(binario,2));
                returnValue = valueParse.ToString();
            }
            return returnValue;
        }

        /// <summary>
        /// Convierte decimal a binario un string.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            string returnValue = "Valor invalido";
            double doubleToParse;
            if(double.TryParse(numero, out doubleToParse))
            {
                returnValue = this.DecimalBinario(doubleToParse);
            }
            return returnValue;
        }
        
        /// <summary>
        /// Convierte de decimal a binario un numero double.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        string DecimalBinario(double numero)
        {
            string returnValue = "Valor invalido";
            int numAbsoluto = (int)Math.Abs(numero);
            returnValue = Convert.ToString(numAbsoluto, 2);
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

        /// <summary>
        /// En caso de solicitar una division por cero se retorna double.MinvValue
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
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
