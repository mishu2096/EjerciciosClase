using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Matematica.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        //NOMBRE DE LA PRUEBA PRIMER PASO ARANGE
        public void Suma()
        {
            //PROCESO
            var sumando1 = 20;
            var sumando2 = 20;
            var esperado = 40;
            //instancio el objeto calculadora
            var calculadora = new Calculadora();
            var resultado = calculadora.Sumar(sumando1, sumando2);
            //vefifico
            Assert.AreEqual(esperado, resultado);

        }

        [TestMethod]
        public void ObtenerDivision2Numeros()
        {
            var dividendo = 24;
            var divisor = 2;
            var esperado = 12;

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Dividir(dividendo, divisor);

            Assert.AreEqual(esperado, resultado);
        }


        [TestMethod]
        public void Dividir0()
        {
            var dividendo = 0;
            var divisor = 5;
            var esperado = 0;

            var calculadora = new Calculadora();
            var resultado = calculadora.Dividir(dividendo, divisor);

            Assert.AreEqual(esperado, resultado);

        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionPor0()
        {
            var dividendo = 20;
            var divisor = 0;


            var calculadora = new Calculadora();
            var resultado = calculadora.Dividir(dividendo, divisor);

            // Assert.IsTrue(double.IsInfinity(resultado));
        }

        [TestMethod]
        public void DivisionDecimal()
        {
            var dividendo = 15;
            var divisor = 2;
            var esperado = 7.5;

            var calculadora = new Calculadora();
            var resultado = calculadora.Dividir(dividendo, divisor);

            Assert.AreEqual(esperado, resultado);

        }

        [TestMethod]
        public void ObtenerResta2Numeros()
        {
            var minuendo = 56;
            var sustraendo = 20;
            var espera = 36;

            var calculadora = new Calculadora();
            var resultado = calculadora.Resta(minuendo, sustraendo);

            Assert.AreEqual(espera, resultado);

        }
        [TestMethod]
        public void LimitarDecimales()
        {
            var numeroDecimal = 1.61803398874989;
            var numeroLimitado = (Math.Round(numeroDecimal, 3));
            var espera = 1.618;

            var calculadora = new Calculadora();
            var resultado = calculadora.Limitar(numeroDecimal, numeroLimitado);

            Assert.AreEqual(espera, resultado);

        }

        [TestMethod]
        public void ObtenerUnNumeroConDosDecimal()
        {
            // Arrange -> Preparacion
            var numeroPiCon5Decimales = 3.14159;
            var numeroPiCon2Decimales = 3.14;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultado = calculadora.TomarDosDecimales(numeroPiCon5Decimales);

            // assert -> Verificación
            Assert.AreEqual(numeroPiCon2Decimales, resultado);

        }

        [TestMethod]
        public void ObtenerUnNumeroCon3Decimal()
        {
            // Arrange -> Preparacion
            var numeroPiConDecimales = 3.141592653589793238462643383;
            var numeroPiCon3Decimales = 3.141;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultado = calculadora.TomarTresDecimales(numeroPiConDecimales);

            // assert -> Verificación
            Assert.AreEqual(numeroPiCon3Decimales, resultado);

        }
        [TestMethod]
        public void ObtenerNDecimales()
        {
            // Arrange -> Preparacion
            var numeroAureo = 1.61803398874989;
            var numeroDecimales = 5;
            var esperado = 1.61803;

           // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultado = calculadora.TomarDecimales(numeroAureo, numeroDecimales);
            // assert -> Verificación
            Assert.AreEqual(esperado, resultado);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ObtenerNDecimalesN()
        {
            // Arrange -> Preparacion
            var numeroAureo = 1.61803398874989;
            var numeroDecimalesNegativo = -5;
       

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            _ = calculadora.TomarDecimales(numeroAureo, numeroDecimalesNegativo);
            // assert -> Verificación
         

        }

        [TestMethod]
       // [DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0; Data Source=C:\Data\MathsData.sdf;", "Numbers")]
        public void AumentarEntero()
        {
            var numeroEntero1 = 2;
           // int x = Convert.ToInt32(TestContext.DataRow["FirstNumber"]);
            var numeroEntero2 = -3;
            var esperado = -1;

            var calculadora = new Calculadora();
            int resultado = calculadora.AumentarEntero(numeroEntero1, numeroEntero2);

            Assert.AreEqual(esperado, resultado);
        }





    }





    }

