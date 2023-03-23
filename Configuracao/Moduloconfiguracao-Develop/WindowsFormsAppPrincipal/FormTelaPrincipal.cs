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
using BLL;
using Models;

namespace WindowsFormsAppPrincipal
{
    public partial class FormTelaprincipal : Form
    {
        public FormTelaprincipal()
        {
            InitializeComponent();
            //Usuario usuario = new Usuario();
            //usuario.NomeUsuario = "Rosilene";
            //usuario.Nome = "Rosa";
            //usuario.Email = "Clementerosa@gmail.com";
            //usuario.CPF = "456.556.015.91";
            //usuario.Senha = "R12356c";
            //usuario.Ativo = true;

            
            //usuario.NomeUsuario = "WilllianAraujo";
            //usuario.Nome = "Willian";
            //usuario.Email = "Solbrilha@gmail.com";
            //usuario.CPF = "564.556.234.00";
            //usuario.Senha = "5689";
            //usuario.Ativo = true;

            
            //usuario.NomeUsuario = "Solangesilva";
            //usuario.Nome = "Solange";
            //usuario.Email = "ceuazul@hotmail.com";
            //usuario.CPF = "333.286.015.30";
            //usuario.Senha = "569201";
            //usuario.Ativo = true;

            //new UsuarioBLL(). Inserir(usuario);
        }

        private void FormTelaprincipal_Load(object sender, EventArgs e)
        {
            Contantes.IdUsuarioLogado = 6;
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void grupoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarGrupoUsuario frm = new FormBuscarGrupoUsuario())
            {
                frm.ShowDialog();
            }
        }
    }
}
