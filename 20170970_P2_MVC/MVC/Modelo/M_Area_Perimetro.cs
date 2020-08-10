using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Modelo
{
    public class M_Area_Perimetro
    {
        public double AreaRectangulo(double Base, double altura) { return Base * altura; }
        public double PerimetroRectangulo(double Base, double altura) { return (Base + altura) * 2; }
        public double AreaTriangulo(double Base, double altura) { return (Base * altura)/2; }
        public double PerimetroTriangulo(double lado) { return lado*3; }
        public double AreaCuadrado(double lado){ return lado * lado; }
        public double PerimetroCuadrado(double lado){return lado * 4;}
    }
}
