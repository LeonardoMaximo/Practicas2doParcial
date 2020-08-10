using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Area_Perimetro
{
    public class Octagono : Ifigura
    {
        public override double Area(Variables vari)
        {
            return (Perimetro(vari) * vari.GetApotema1() / 2);
        }

        public override string Descripcion()
        {
            return "Es un octagono";
        }

        public override double Perimetro(Variables vari)
        {
            return vari.GetLado1() * 8;
        }
    }
}
