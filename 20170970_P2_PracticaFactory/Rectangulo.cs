using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Area_Perimetro
{
    public class Rectangulo : Ifigura
    {
        public override double Area(Variables vari)
        {
            return vari.GetBase1() * vari.GetAltura1();
        }

        public override string Descripcion()
        {
            return "Es un Rectangulo";
        }

        public override double Perimetro(Variables vari)
        {
            return (vari.GetBase1() + vari.GetAltura1())*2;
        }
    }
}
