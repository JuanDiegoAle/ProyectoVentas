using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoVentas.Models;

namespace ProyectoVentas
{
    public partial class FormCarga : Form

    {
        private string usuario;
        public FormCarga(string usuario)
        {
            InitializeComponent();
            this.usuario= usuario;
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            {
                progressBar1.Value+=1;
            }
            if (progressBar1.Value==100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity-= 0.05;
            if (this.Opacity==0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void FormCarga_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            lblUsuario.Text = usuario;
            timer1.Start();
        }
    }
}
