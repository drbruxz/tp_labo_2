﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        //public string Message;
        public NacionalidadInvalidaException()
        {

        }
        
        public NacionalidadInvalidaException(string message) : base(message)
        {
        }
    }
}
