using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormCadastrodeUsuario : Form
    {
        
        public int id;
        public FormCadastrodeUsuario( int _id = 0)
         {
            InitializeComponent();
            id = _id;
        }

        private void CadastrodeUsuario_Load(object sender, EventArgs e)
        {
            if(id == 0)
                usuarioBindingSource.AddNew();
            else
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorId(id);

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.EndEdit();

                if (id == 0)
                    usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current, textBoxConfirmacao.Text);
                else
                    usuarioBLL.Alterar((Usuario)usuarioBindingSource.Current, textBoxConfirmacao.Text);

                MessageBox.Show("Registro salvo com sucesso");
                Close();
            }
             catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxConfirmacao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
