using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Area_Perimetro
{
    public class Variables
    {
        private double Base;
        private double Altura;
        private double Lado;
        private double Radio;
        private double Apotema;

        public double GetRadio1()
        {
            return Radio;
        }

        public void SetRadio1(double value)
        {
            Radio = value;
        }

        public double GetApotema1()
        {
            return Apotema;
        }

        public void SetApotema1(double value)
        {
            Apotema = value;
        }

        public double GetLado1()
        {
            return Lado;
        }

        public void SetLado1(double value)
        {
            Lado = value;
        }

        public double GetAltura1()
        {
            return Altura;
        }

        public void SetAltura1(double value)
        {
            Altura = value;
        }

        public double GetBase1()
        {
            return Base;
        }

        public void SetBase1(double value)
        {
            Base = value;
        }
    }
}
