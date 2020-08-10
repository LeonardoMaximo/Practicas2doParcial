using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Area_Perimetro
{
    public abstract class Ifigura
    {
        public abstract double Area(Variables vari);
        public abstract double Perimetro(Variables vari);
        public abstract string Descripcion();
    }
}
