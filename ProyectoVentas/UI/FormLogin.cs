using ProyectoVentas.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVentas
{
    public partial class FormLogin : Form
    {
        private UsuarioRepository repo=new UsuarioRepository();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario=txtUsuario.Text;
            string password=txtPassword.Text;

            bool acceso=repo.Login(usuario, password); 

            if (acceso)
            {
                MessageBox.Show("Bienvenido "+usuario);

                FormPedido form=new FormPedido();

                this.Hide();

                form.ShowDialog();

                this.Close();

                
            }else
            {
                MessageBox.Show("Usuario o contraseña Incorrectos");
            }
        }
    }
}
