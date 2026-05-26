using ProyectoVentas.Interfaces;
using ProyectoVentas.Repository;
using ProyectoVentas.Services;
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
        private IUsuarioRepository repo;
        public FormLogin(IUsuarioRepository usuariorepo)
        {
            InitializeComponent();
            repo = usuariorepo;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            bool acceso = repo.Login(usuario, password);

            if (acceso)
            {
                string rol = repo.ObtenerRol(usuario);

                MessageBox.Show("Bienvenido " + rol + ": " + usuario);

                IPedidoRepository pedidoRepo = new PedidoRepository();
                IPagoService pagoService = new PagoService();

                FormPedido form = new FormPedido(rol, usuario, pedidoRepo, pagoService);

                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
