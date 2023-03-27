using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormCadastroGrupoUsuario : Form
    {
        public int id;
        public FormCadastroGrupoUsuario(int _id = 0)
        {
            InitializeComponent();

            id = _id;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
            grupoUsuarioBindingSource.EndEdit();

            if (id == 0)
                grupousuarioBLL.Inserir((GrupoUsuario)grupoUsuarioBindingSource.Current);
            else
                grupousuarioBLL.Alterar((GrupoUsuario)grupoUsuarioBindingSource.Current);

            MessageBox.Show("Registro salvo com sucesso");
            Close();
        }

        private void FormCadastroGrupoUsuario_Load(object sender, EventArgs e)
        {
            if (id == 0)
                grupoUsuarioBindingSource.AddNew();

            else
                grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarPorId(id);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
