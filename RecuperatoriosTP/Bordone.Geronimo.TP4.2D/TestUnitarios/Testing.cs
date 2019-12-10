using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using MainCorreo;

namespace TestUnitarios
{

    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void IsCorreoNotNull()
        {
            //Arrange
            Correo c;

            //Act
            c = new Correo();

            //Assert
            Assert.IsNotNull(c.Paquetes);
        }


        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void ImposibleCargarPaqueteDuplicado()
        {
            //Arrange
            Paquete p1, p2;
            Correo c;
            c = new Correo();
            p1 = new Paquete("Direccion1", "123456789");
            p2 = new Paquete("Direccion2", "123456789");
            
            //Act
            c += p1;
            c += p2;
        }


    }
}
