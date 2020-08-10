using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Area_Perimetro
{
    public class Circulo: Ifigura
    {
        public override double Area(Variables vari)
        {
            return 3.1416 * (Math.Pow(vari.GetRadio1(), 2));
           
        }
        public override string Descripcion()
        {
            return "Es un circulo";
        }

        public override double Perimetro(Variables vari)
        {
            return (2 * 3.1416) * vari.GetRadio1();
        }
    }
}
