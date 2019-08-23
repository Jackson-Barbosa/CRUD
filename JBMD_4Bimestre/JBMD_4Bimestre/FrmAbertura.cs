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
    public partial class FrmAbertura : Form
    {
        public FrmAbertura()
        {
            InitializeComponent();
            //Executando o metodo Desaparecer deste Form.
            desaparecer();
        }
        private void desaparecer()
        {   //Modificando Transparencia, ativando o timer e Executando ações pré-programadas.
            TmrContador.Tick += new EventHandler(TmrContador_Tick);
            TmrContador.Enabled = true;         
            this.Opacity = 1;
        }

        private void TmrContador_Tick(object sender, EventArgs e)
        {
            //Executando ações em determinadas condições.
            bool ativo = true;
            if (ativo && this.Opacity > 0.7)
            {
                this.Opacity -= 0.0035D;

            }
            else
            {
                this.Opacity -= 0.1D;
            }
            if (this.Opacity == 0)
            {
                ativo = false;
                TmrContador.Enabled = false;
                //Alterando de Form.
                FrmLogin mudando = new FrmLogin();
                mudando.ShowDialog();
                this.Close();
            }
        }
    }
}
