using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Area_Perimetro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxFigura.SelectedIndex = 0;
            cbxOperacion.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variables variable = new Variables();

            double bas;
            if (String.IsNullOrEmpty(txtbase.Text))
                bas = 0;
            else
                bas = double.Parse(txtbase.Text);

            double altura;
            if (String.IsNullOrEmpty(txtaltura.Text))
                altura = 0;
            else
                altura = double.Parse(txtbase.Text);

            if (cbxFigura.SelectedIndex == 0 && cbxOperacion.SelectedIndex == 0)
            {
                variable.SetBase1(bas);
                variable.SetAltura1(altura);
                Ifigura figura = Factory.ver(Factory.tri);
                double res = figura.Area(variable);
                txtresultado.Text = res.ToString();
                txtmensaje.Text = figura.Descripcion();
            }
            if (cbxFigura.SelectedIndex == 0 && cbxOperacion.SelectedIndex == 1)
            {
                variable.SetLado1(bas);
                Ifigura figura = Factory.ver(Factory.tri);
                double res = figura.Perimetro(variable);
                txtresultado.Text = res.ToString();
                txtmensaje.Text = figura.Descripcion();
            }
            if (cbxFigura.SelectedIndex == 1 && cbxOperacion.SelectedIndex == 0)
            {
                variable.SetRadio1(bas);
                Ifigura figura = Factory.ver(Factory.circulo);
                double res = figura.Area(variable);
                txtresultado.Text = res.ToString();
                txtmensaje.Text = figura.Descripcion();
            }
            if (cbxFigura.SelectedIndex == 1 && cbxOperacion.SelectedIndex == 1)
            {
                variable.SetRadio1(bas);
                Ifigura figura = Factory.ver(Factory.circulo);
                double res = figura.Perimetro(variable);
                txtresultado.Text = res.ToString();
                txtmensaje.Text = figura.Descripcion();
            }
            if (cbxFigura.SelectedIndex == 2 && cbxOperacion.SelectedIndex == 0)
            {
                variable.SetLado1(bas);
                Ifigura figura = Factory.ver(Factory.cuadrado);
                double res = figura.Area(variable);
                txtresultado.Text = res.ToString();
                txtmensaje.Text = figura.Descripcion();
            }
            if (cbxFigura.SelectedIndex == 2 && cbxOperacion.SelectedIndex == 1)
            {
                variable.SetLado1(bas);
                Ifigura figura = Factory.ver(Factory.cuadrado);
                double res = figura.Perimetro(variable);
                txtresultado.Text = res.ToString();
                txtmensaje.Text = figura.Descripcion();
            }
            if (cbxFigura.SelectedIndex == 3 && cbxOperacion.SelectedIndex == 0)
            {
                variable.SetBase1(bas);
                variable.SetAltura1(altura);
                Ifigura figura = Factory.ver(Factory.rectangulo);
                double res = figura.Area(variable);
                txtresultado.Text = res.ToString();
                txtmensaje.Text = figura.Descripcion();
            }
            if (cbxFigura.SelectedIndex == 3 && cbxOperacion.SelectedIndex == 1)
            {
                variable.SetBase1(bas);
                variable.SetAltura1(altura);
                Ifigura figura = Factory.ver(Factory.rectangulo);
                double res = figura.Perimetro(variable);
                txtresultado.Text = res.ToString();
                txtmensaje.Text = figura.Descripcion();
            }
            if (cbxFigura.SelectedIndex == 4 && cbxOperacion.SelectedIndex == 0)
            {
                variable.SetApotema1(bas);
                Ifigura figura = Factory.ver(Factory.octagono);
                double res = figura.Area(variable);
                txtresultado.Text = res.ToString();
                txtmensaje.Text = figura.Descripcion();
            }
            if (cbxFigura.SelectedIndex == 4 && cbxOperacion.SelectedIndex == 1)
            {
                variable.SetLado1(bas);
                Ifigura figura = Factory.ver(Factory.octagono);
                double res = figura.Perimetro(variable);
                txtresultado.Text = res.ToString();
                txtmensaje.Text = figura.Descripcion();
            }


        }

        private void cbxOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarSelección();
        }

        private void cbxFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarSelección();
        }

        public void VerificarSelección()
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
            if (cbxFigura.SelectedIndex == 0 && cbxOperacion.SelectedIndex == 0)
            {
                lblbase.Text = "Base";
                txtaltura.Visible = true;
                lblaltura.Visible = true;
            }
            // Perimetro de Triangulo
            if (cbxFigura.SelectedIndex == 0 && cbxOperacion.SelectedIndex == 1)
            {
                lblbase.Text = "Lado";
                txtaltura.Visible = false;
                lblaltura.Visible = false;
            }
            // Area y Perimetro de Circulo
            if (cbxFigura.SelectedIndex == 1)
            {
                lblbase.Text = "Radio";
                txtaltura.Visible = false;
                lblaltura.Visible = false;
            }
            // Area y Perimetro de Cuadrado
            if (cbxFigura.SelectedIndex == 2)
            {
                lblbase.Text = "Lado";
                txtaltura.Visible = false;
                lblaltura.Visible = false;
            }
            // Area y Perimetro de Rectángulo
            if (cbxFigura.SelectedIndex == 3)
            {
                lblbase.Text = "Base";
                txtaltura.Visible = true;
                lblaltura.Visible = true;
            }
            // Area de Octágono
            if (cbxFigura.SelectedIndex == 4 && cbxOperacion.SelectedIndex == 0)
            {
                lblbase.Text = "Apotema";
                txtaltura.Visible = false;
                lblaltura.Visible = false;
            }
            // Perimetro de Octágono
            if (cbxFigura.SelectedIndex == 4 && cbxOperacion.SelectedIndex == 1)
            {
                lblbase.Text = "Lado";
                txtaltura.Visible = false;
                lblaltura.Visible = false;
            }
        }
    }
}
