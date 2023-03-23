using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using BLL;
using Models;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarUsuario : Form
    {
        public object IdUsuario { get; private set; }

        public FormBuscarUsuario()

        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarTodos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExcluirusauario_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Usuario)usuarioBindingSource.Current).Id;
            new UsuarioBLL().Excluir(id);
            usuarioBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluído com sucesso!");
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não há registro selecionar para ser alterado.");
                return;
            }
            else
            {
                int id = ((Usuario)usuarioBindingSource.Current).Id;

                using (FormCadastrodeUsuario frm = new FormCadastrodeUsuario(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);

            }

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            using (FormCadastrodeUsuario frm = new FormCadastrodeUsuario())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonAdicionagrupousuario_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaGrupoUsuario frm = new FormConsultaGrupoUsuario())
                {
                    frm.ShowDialog();
                    if (frm.Id != 0)
                    {
                        int idUsuario = ((Usuario)usuarioBindingSource.Current).Id;
                        new UsuarioBLL().AdicionarGrupoUsuario(idUsuario, frm.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.InnerException.Message);
            }
        }

        private void buttonExcluirgrupousuario_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ((GrupoUsuario)gPusuariosBingindSource.Current).IdGrupo;
                int idUsuario = ((Usuario)UsuarioBindingSource.Current).Id;
                new UsuarioBLL().RemoverGrupo
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
    

