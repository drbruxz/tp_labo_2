using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        #region Validaciones

        /// <summary>
        /// Valida que el operador sea uno de los cuatro válidos.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperador(string operador)
            {
                string returnValue;

                switch (operador)
                {
                    case "+":
                        returnValue = "+";
                        break;
                    case "-":
                        returnValue = "-";
                        break;
                    case "*":
                        returnValue = "*";
                        break;
                    case "/":
                        returnValue = "/";
                        break;
                    default:
                        returnValue = "+";
                        break;
                }
                return returnValue;
            }


            /// <summary>
            /// Realiza la operacion recibiendo ambos números y el string del operador.
            /// </summary>
            /// <param name="num1"></param>
            /// <param name="num2"></param>
            /// <param name="operador"></param>
            /// <returns></returns>
            public static double Operar(Numero num1, Numero num2,string operador)
            {
                operador = ValidarOperador(operador);
                double returnValue = 0;
                switch (operador)
                {
                    case "+":
                        returnValue = num1 + num2;
                        break;
                    case "-":
                        returnValue = num1 - num2;
                        break;
                    case "*":
                        returnValue = num1 * num2;
                        break;
                    case "/":
                        returnValue = num1 / num2;
                        break;
                }
                return returnValue;
            }
            #endregion

    }
}
