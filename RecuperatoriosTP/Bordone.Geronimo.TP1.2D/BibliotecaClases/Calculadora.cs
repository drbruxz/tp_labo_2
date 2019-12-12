using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Bordone
{
    public static class Calculadora
    {

    #region Validaciones
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
