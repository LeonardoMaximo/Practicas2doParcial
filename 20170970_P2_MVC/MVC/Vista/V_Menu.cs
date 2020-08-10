using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC.Controlador;


namespace MVC.Vista
{
    public partial class V_Menu : Form
    {

        public V_Menu()
        {
            InitializeComponent();
            C_Calcular ctrl = new C_Calcular(this);
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
