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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            //Saindo do form com verificação.
            if (MessageBox.Show("Deseja sair do programa?", "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {   //Colocando o botão ESC do teclado com a mesma função do BtnSair.
            if (e.KeyCode == Keys.Escape)
                BtnSair.PerformClick();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {   //Limpando os TextBox deste Form.
            foreach (Control i in this.Controls)
            {
                if (i is TextBox)
                {
                    i.Text = "";
                }
            }
        }
        // **Video - Tutorial 1 -como fazer um CRUD simples C# -

        SqlConnection sqlCon = null; 
        private string strCon = /*@*/"SERVER=localhost; DATABASE=programa; UID=root; PWD=root";
        private string strSql = string.Empty;

        private void BtnRealizar_Click(object sender, EventArgs e)
        {
            //Verificando se é um cadastro ou pesquisa.
            if (RbtnCadastrar.Checked == true)
            {
               

                // **Video - Tutorial 1 -como fazer um CRUD simples C# -nomes devem estar da mesma forma do banco
                strSql= "Insert into clientes( nome, acesso, graduacao, universidade, cargo, nacionalidade, empresa,contato ,nascimento) values(@nome, @acesso, @graduacao, @universidade, @cargo, @nacionalidade, @empresa,@contato ,@nascimento)";
                sqlCon= new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.add("@nome", SqlDbType.VarChar).Value = TxtNome.Text;
                comando.Parameters.add("@acesso", SqlDbType.VarChar).Value = TxtAcesso.Text;
                comando.Parameters.add("@graduacao", SqlDbType.VarChar).Value = TxtGraduacao.Text;
                comando.Parameters.add("@universidade", SqlDbType.VarChar).Value = TxtUniversidade.Text;
                comando.Parameters.add("@cargo", SqlDbType.VarChar).Value = TxtCargo.Text;
                comando.Parameters.add("@nacionalidade", SqlDbType.VarChar).Value = TxtNacionalidade.Text;
                comando.Parameters.add("@empresa", SqlDbType.VarChar).Value = TxtEmpresa.Text;
                comando.Parameters.add("@contato", SqlDbType.VarChar).Value = maskedTextBox1.Text;
                comando.Parameters.add("@nascimento", SqlDbType.VarChar).Value =  DtpNascido.Text;

                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("CADASTRO OK.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                    BtnLimpar.PerformClick();
                }
            }
            if (RbtnPesquisar.Checked == true && txtPesquisa.Text !="")
            {
                // **Video - Tutorial 1 -como fazer um CRUD simples C# -nomes devem estar da mesma forma do banco

                strSql = "SELECT * FROM clientes where nome=@pesquisa";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.add("@pesquisa", SqlDbType.VarChar).Value = txtPesquisa.Text;
               
                try
                {
                     sqlCon.Open();
                     SqlDataReader dr = comando.ExecuteReader();

                    if (dr.HasRows == false)
                    {
                        throw new Exception("NÃO CADASTRADO NO SISTEMA.");
                    }
                    dr.Read();

                    TxtNome.Text = Convert.ToString(dr["nome"]);
                    TxtAcesso.Text = Convert.ToString(dr["acesso"]);
                    TxtGraduacao.Text = Convert.ToString(dr["graduacao"]);
                    TxtUniversidade.Text = Convert.ToString(dr["universidade"]);
                    TxtCargo.Text = Convert.ToString(dr["cargo"]);
                    TxtNacionalidade.Text = Convert.ToString(dr["nacionalidade"]);
                    TxtEmpresa.Text = Convert.ToString(dr["empresa"]);
                    maskedTextBox1.Text = Convert.ToString(dr["contato"]);
                    DtpNascido.Text = Convert.ToString(dr["nascimento"]);

                }
                                                                         
                catch (Exception ex)
                { MessageBox.Show(ex.Message);}

                finally
                {
                    sqlCon.Close();
                    txtPesquisa.Text = "";
                }
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
           /* ClasseDLL Dll = new ClasseDLL();

            try
            {
                DtgClientes.DataSource = Dll.ExibirDadosDal();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao exibir a tabela" + erro);
            }*/
        }

        private void gerênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre Sobre = new FrmSobre();
            Sobre.ShowDialog();
        }

        private void BtnOkEmpresa_Click(object sender, EventArgs e)
        {
            if (TxtEmpresa.Text != "")
            {
                txtPesquisa.Text = TxtEmpresa.Text;
            }
        }

        private void BtnOkNome_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text != "")
            {
                txtPesquisa.Text = TxtNome.Text;
            }
        }

        private void BtnOkCodigo_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "")
            {
                txtPesquisa.Text = TxtCodigo.Text;
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
          
            strSql = "UPDATE clientes SET nome=@nome, acesso=@acesso, graduacao=@graduacao, universidade=@universidade, cargo=@cargo, nacionalidade=@nacionalidade, empresa=@empresa, conato=@contato, nascimento=@nascimento";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.add("@nome", SqlDbType.VarChar).Value = TxtNome.Text;
            comando.Parameters.add("@acesso", SqlDbType.VarChar).Value = TxtAcesso.Text;
            comando.Parameters.add("@graduacao", SqlDbType.VarChar).Value = TxtGraduacao.Text;
            comando.Parameters.add("@universidade", SqlDbType.VarChar).Value = TxtUniversidade.Text;
            comando.Parameters.add("@cargo", SqlDbType.VarChar).Value = TxtCargo.Text;
            comando.Parameters.add("@nacionalidade", SqlDbType.VarChar).Value = TxtNacionalidade.Text;
            comando.Parameters.add("@empresa", SqlDbType.VarChar).Value = TxtEmpresa.Text;
            comando.Parameters.add("@contato", SqlDbType.VarChar).Value = maskedTextBox1.Text;
            comando.Parameters.add("@nascimento", SqlDbType.VarChar).Value = DtpNascido.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Atualizado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
                BtnLimpar.PerformClick();
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            strSql = "DELETE FROM clientes WHERE nome=@nome";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.add("@nome", SqlDbType.VarChar).Value = TxtNome.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Excluido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
                BtnLimpar.PerformClick();
            }

        }
    }
}
