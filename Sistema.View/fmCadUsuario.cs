using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.View
{
    public partial class fmCadUsuario : Form
    {
        public fmCadUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            opc = "Excluir";
            iniciarOpc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opc = "Editar";
            iniciarOpc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iniciarOpc();
            HabilitarCampos();
            LimparCampos();
        }
        private string opc = "";

        private void iniciarOpc()
        {
            switch (opc)
            {
                case "Novo": HabilitarCampos();
                    LimparCampos();
                    break;

                case "Salvar":
                    break;
                case "Excluir":
                    break;
            }
            
        }
        //vamos criar as funções abaixo

        private void HabilitarCampos(){
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            opc = "Salvar";
            iniciarOpc();
        }

        private void fmCadUsuario_Load(object sender, EventArgs e)
        {
            opc = "Novo";
            iniciarOpc();
        }
    }
}
