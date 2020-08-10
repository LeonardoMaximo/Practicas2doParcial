using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Area_Perimetro
{
    public class Factory
    {
        public const int tri = 1;
        public const int circulo = 2;
        public const int cuadrado = 3;
        public const int rectangulo = 4;
        public const int octagono = 5;
        public static Ifigura ver(int tipo)
        {
            switch (tipo)
            {
                case tri:
                    return new Triangulo();
                case circulo:
                    return new Circulo();
                case cuadrado:
                    return new Cuadrado();
                case rectangulo:
                    return new Rectangulo();
                case octagono:
                    return new Octagono();
                default:
                    return null;
            }

        }
    }
}
