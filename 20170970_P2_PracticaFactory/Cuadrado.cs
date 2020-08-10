using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Area_Perimetro
{
    public class Cuadrado : Ifigura
    {
        public override double Area(Variables vari)
        {
            return vari.GetLado1() * vari.GetLado1();
        }

        public override string Descripcion()
        {
            return "Es un cuadrado";
        }

        public override double Perimetro(Variables vari)
        {
            return vari.GetLado1() * 4;
        }
    }
}
