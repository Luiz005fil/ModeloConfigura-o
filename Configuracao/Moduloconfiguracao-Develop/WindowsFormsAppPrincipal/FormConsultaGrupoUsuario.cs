
﻿using Models;
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

namespace WindowsFormsAppPrincipal
{
    public partial class FormConsultaGrupoUsuario : Form
    {
        public int Id;
        public FormConsultaGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gPusuariosBindingSource.DataSource = new GrupoUsuarioBLL().BuscarPorNome(textBoxBuscar.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gPusuariosBindingSource.Count > 0)
                {
                    Id = ((GrupoUsuario)gPusuariosBindingSource.Current).IdGrupo;
                   
                   Close();
                }
                else
                {

                    MessageBox.Show("Não existe registro para ser selecionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
                 
               

