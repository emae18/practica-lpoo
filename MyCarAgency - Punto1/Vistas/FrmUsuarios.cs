using Dominio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmUsuarios : Form
    {
        private UserModel usuarios = new UserModel();

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            usuarios.AltaUsuario(
                txtLoginUser.Text,
                txtPassword.Text,
                txtFirstName.Text,
                txtLastName.Text,
                int.Parse(txtAge.Text),
                txtRole.Text);
            
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            listarUsuarios();
        }

        private void listarUsuarios()
        {
            dgvUsuarios.DataSource= usuarios.ListarUsuarios();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            User oUsuario = (User)dgvUsuarios.Rows[e.RowIndex].DataBoundItem;
            txtId.Text = oUsuario.idUser.ToString();
            txtLoginUser.Text = oUsuario.loginName;
            txtFirstName.Text = oUsuario.firstName;
            txtLastName.Text = oUsuario.lastName;
            txtPassword.Text = oUsuario.password;
            txtRole.Text = oUsuario.role;
            txtAge.Text = oUsuario.age.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            usuarios.ModificarUsuario(int.Parse(txtId.Text),
                txtLoginUser.Text,
                txtPassword.Text,
                txtFirstName.Text,
                txtLastName.Text,
                int.Parse(txtAge.Text),
                txtRole.Text);
            listarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            usuarios.EliminarUsuario(int.Parse(txtId.Text));
            listarUsuarios();
        }
    }
}
