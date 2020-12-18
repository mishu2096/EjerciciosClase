
using System;

namespace Matematica
{
    public class Calculadora
    {
        public int Sumar(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;

        }
        public double Dividir(double dividendo, double divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException();

            return dividendo / divisor;

        }



        public int Resta(int minuendo, int sustraendo)
        {
            return minuendo - sustraendo;

        }




        public double Limitar(double numeroDecimal, double numeroLimitado)
        {
            return numeroLimitado;
        }

        public double TomarDosDecimales(double numeroConDecimales)
        {
            var numeroPaso1 = MoverLaComaALaDerecha2Veces(numeroConDecimales);
            var numeroPaso2 = TomarParteEntera(numeroPaso1);
            var numeroPaso3 = MoverLaComaALaIzquierda2Veces(numeroPaso2);
            return numeroPaso3;
        }

        private double MoverLaComaALaDerecha2Veces(double numeroConDecimales)
        {
            return numeroConDecimales * 100;
        }

        private double TomarParteEntera(double numeroConDecimales)
        {
            return Math.Truncate(numeroConDecimales);
        }

        private double MoverLaComaALaIzquierda2Veces(double numero)
        {
            return numero / 100;
        }

        public double TomarTresDecimales(double numero)
        {
            var numeroPaso1 = MoverLaComaALaDerecha3Veces(numero);
            var numeroPaso2 = TomarParteEntera(numeroPaso1);
            var numeroPaso3 = MoverLaComaALaIzquierda3Veces(numeroPaso2);
            return numeroPaso3;
        }

        private double MoverLaComaALaDerecha3Veces(double numero)
        {
            return numero * 1000;
        }

        private double MoverLaComaALaIzquierda3Veces(double numero)
        {
            return numero / 1000;
        }

        public double TomarDecimales(double numero, int numeroDecimales)
        {
            if (numeroDecimales < 0)
                throw new ArgumentException("no puede ser negativo");
            var numeroPaso1 = MoverLaComaALaDerecha(numero, numeroDecimales);
            var numeroPaso2 = TomarParteEntera(numeroPaso1);
            var numeroPaso3 = MoverLaComaALaIzquierda(numeroPaso2, numeroDecimales);
            return numeroPaso3; ;
        }

        private double MoverLaComaALaDerecha(double numero, int numeroDecimales)
        {
            //1-->**10
            //2-->**100
            return numero * Math.Pow(10, numeroDecimales);
        }
        private double MoverLaComaALaIzquierda(double numero, int numeroDecimales)
        {
            //1--./10
            //2/100
            return numero / Math.Pow(10, numeroDecimales);
        }

        public int AumentarEntero(int numeroEntero1, int numeroEntero2)
        {
            var suma = numeroEntero1;
            for (var i=0; i< numeroEntero2; i++)
            {
                suma++;
            }
            return suma;
        }
    }


}



