using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBMD_4Bimestre
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        { //Saindo do form com verificação.
            if (MessageBox.Show("Deseja sair do programa?", "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            //Resetando as imagens e labels de controle.
            LblIncompativel.Visible = false;
            PbxCirculoUsuario.Visible = false;
            PbxCirculoSenha.Visible = false;
            //Verificando as combinaçoes de senha e usuário e realizando uma ação dependendo do resultado.
            if (TxtUsuario.Text != "" && TxtSenha.Text != "")
            {
                if (TxtUsuario.Text == "admin" && TxtSenha.Text == "admin")
                {
                    this.Opacity = 0;
                    //Mudando de Form.
                    FrmPrincipal mudando = new FrmPrincipal();
                    mudando.ShowDialog();
                    this.Close();
                }
                if (TxtUsuario.Text == "admin" && TxtSenha.Text != "admin")
                {
                    LblIncompativel.Visible = true;
                    PbxCirculoSenha.Visible = true;
                }
                if (TxtUsuario.Text != "admin" && TxtSenha.Text == "admin")
                {
                    LblIncompativel.Visible = true;
                    PbxCirculoUsuario.Visible = true;
                }
                if (TxtUsuario.Text != "admin" && TxtSenha.Text != "admin")
                {
                    LblIncompativel.Visible = true;
                    PbxCirculoUsuario.Visible = true;
                    PbxCirculoSenha.Visible = true;
                }
            }
            else {
                MessageBox.Show("Preencha todos os campos.");
                TxtUsuario.Focus();
            }
        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        { //Escondendo a Senha.
            TxtSenha.PasswordChar = '*';
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        { //Colocando o botão ESC do teclado com a mesma função do BtnSair.
            if (e.KeyCode == Keys.Escape)
                BtnSair.PerformClick();
        }

        private void gerênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre Sobre = new FrmSobre();
            Sobre.ShowDialog();
        }
    }
}
