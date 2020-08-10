using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Modelo;
using MVC.Vista;
using System.Windows.Forms;

namespace MVC.Controlador
{
    public class C_Calcular
    {
        V_Menu menu;
        public C_Calcular(V_Menu main)
        {
            menu = main;
            main.cbxFigura.SelectedIndexChanged += new EventHandler(VerificarSeleccion);
            main.cbxOperacion.SelectedIndexChanged += new EventHandler(VerificarSeleccion);
            main.cbxFigura.SelectedIndex = 0;
            main.cbxOperacion.SelectedIndex = 0;
            main.btnResultado.Click += new EventHandler(mostrar);
        }
        public void mostrar(object sender,EventArgs e)
        {
            M_Area_Perimetro AP = new M_Area_Perimetro();
            if (menu.txtAltura.Text=="" || menu.txtBase.Text=="")
            {
                MessageBox.Show("Favor de llenar los campossssssssss");
            }
            else
            {
                if (menu.cbxFigura.SelectedIndex == 0 && menu.cbxOperacion.SelectedIndex == 0)
                {
                    double Base = double.Parse(menu.txtBase.Text);
                    double Altura = double.Parse(menu.txtAltura.Text);
                    menu.txtResultado.Text = AP.AreaRectangulo(Base, Altura).ToString();
                }
                else if (menu.cbxFigura.SelectedIndex == 0 && menu.cbxOperacion.SelectedIndex == 1)
                {
                    double Base = double.Parse(menu.txtBase.Text);
                    double Altura = double.Parse(menu.txtAltura.Text);
                    menu.txtResultado.Text = AP.PerimetroRectangulo(Base, Altura).ToString();
                }
                else if (menu.cbxFigura.SelectedIndex == 1 && menu.cbxOperacion.SelectedIndex == 0)
                {
                    double Base = double.Parse(menu.txtBase.Text);
                    double Altura = double.Parse(menu.txtAltura.Text);
                    menu.txtResultado.Text = AP.AreaTriangulo(Base, Altura).ToString();
                }
                else if (menu.cbxFigura.SelectedIndex == 1 && menu.cbxOperacion.SelectedIndex == 1)
                {
                    double lado = double.Parse(menu.txtBase.Text);
                    menu.txtResultado.Text = AP.PerimetroTriangulo(lado).ToString();
                }
                else if (menu.cbxFigura.SelectedIndex == 2 && menu.cbxOperacion.SelectedIndex == 0)
                {
                    double lado = double.Parse(menu.txtBase.Text);
                    AP.AreaCuadrado(lado);
                    menu.txtResultado.Text = AP.AreaCuadrado(lado).ToString();
                }
                else if (menu.cbxFigura.SelectedIndex == 2 && menu.cbxOperacion.SelectedIndex == 1)
                {
                    double lado = double.Parse(menu.txtBase.Text);
                    AP.AreaCuadrado(lado);
                    menu.txtResultado.Text = AP.PerimetroCuadrado(lado).ToString();
                }
            }
            
        }
        private void rbLado(object sender, EventArgs e)
        {
            menu.lblBase.Text = "Lado";
            menu.txtAltura.Visible = false;
            menu.lblAltura.Visible = false;
        }
        private void rbBA(object sender, EventArgs e)
        {
            menu.lblBase.Text = "Base";
            menu.txtAltura.Visible = true;
            menu.lblAltura.Visible = true;
        }

        private void VerificarSeleccion(object sender, EventArgs e)
        {
            //cbxFigura
            //    0 = Triangulo
            //    1 = Circulo
            //    2 = Cuadrado
            //    3 = Rectangulo
            //    4 = Octagono
            //cbxOperacion
            //    0 = Area
            //    1 = Perimetro

            // Area de Triangulo
            if (menu.cbxFigura.SelectedIndex == 0 && menu.cbxOperacion.SelectedIndex == 0)
            {
                menu.lblBase.Text = "Base";
                menu.txtAltura.Visible = true;
                menu.lblAltura.Visible = true;
            }
            // Perimetro de Triangulo
            if (menu.cbxFigura.SelectedIndex == 0 && menu.cbxOperacion.SelectedIndex == 1)
            {
                menu.lblBase.Text = "Lado";
                menu.txtAltura.Visible = false;
                menu.lblAltura.Visible = false;
            }
            // Area y Perimetro de Cuadrado
            if (menu.cbxFigura.SelectedIndex == 1)
            {
                menu.lblBase.Text = "Lado";
                menu.txtAltura.Visible = false;
                menu.lblAltura.Visible = false;
            }
            // Area y Perimetro de Rectángulo
            if (menu.cbxFigura.SelectedIndex == 2)
            {
                menu.lblBase.Text = "Base";
                menu.txtAltura.Visible = true;
                menu.lblAltura.Visible = true;
            }
        }
    }
}
