using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficos_por_tortugas
{
    public partial class Form1 : Form
    {
       
        Tortuga Squirlet;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Se utiliza Squirlet para devolver un numero como referencia
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            txtPizarron.Text = Squirlet.ToString();
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            Squirlet.girarIzquierda();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            Squirlet.girarDerecha();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Squirlet.plumaArriba();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            int Avanzaar = Convert.ToInt32(txtAvanzar.Text);
            Squirlet.avanzar(Avanzaar);
        }
    }
}
