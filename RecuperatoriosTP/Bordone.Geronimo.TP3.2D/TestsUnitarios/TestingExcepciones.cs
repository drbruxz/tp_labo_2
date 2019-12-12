using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Abstractas;
using Clases_Instanciables;
using Excepciones;
using Archivos;
namespace TestsUnitarios
{
    [TestClass]
    public class TestingExcepciones
    {
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestNacionalidadInvalida()
        {
            //Arrange
            Profesor p;
            
            //Act
            p = new Profesor(00, "nombre", "apellido", "55555555", Persona.ENacionalidad.Extranjero);
        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestDniInvalido()
        {
            //Arrange
            Profesor p;
            
            //Act
            p = new Profesor(00, "nombre", "apellido", "DNITEXTOINVALIDO", Persona.ENacionalidad.Extranjero);
        }

        [TestMethod]
        public void TestDNI()
        {
            //Arrange
            Alumno a;

            //Act
            a = new Alumno(00, "nombre", "apellido", "55555555", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            //Assert
            Assert.AreEqual(55555555, a.DNI);
        }
        [TestMethod]
        public void TestNombreNotNull()
        {
            //Arrange
            Alumno a;
            
            //Act
            a = new Alumno(00, "nombre", "apellido", "55555555", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            //Assert
            Assert.IsNotNull(a.Nombre);
        }

    }


}
