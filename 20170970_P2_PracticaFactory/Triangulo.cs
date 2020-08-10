using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Area_Perimetro
{
    public class Triangulo : Ifigura
    {
        public override double Area(Variables vari)
        {
 
            return (vari.GetBase1() * vari.GetAltura1()) / 2; 
        }

        public override string Descripcion()
        {
            return "Es un triangulo";
        }

        public override double Perimetro(Variables vari)
        {
            return vari.GetLado1()*3;
        }
    }
}
