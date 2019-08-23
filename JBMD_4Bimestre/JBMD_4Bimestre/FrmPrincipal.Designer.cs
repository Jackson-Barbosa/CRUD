namespace JBMD_4Bimestre
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.MspMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblListaClientes = new System.Windows.Forms.Label();
            this.TxtEmpresa = new System.Windows.Forms.TextBox();
            this.LblEmpresa = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.BtnOkEmpresa = new System.Windows.Forms.Button();
            this.BtnOkNome = new System.Windows.Forms.Button();
            this.BtnOkCodigo = new System.Windows.Forms.Button();
            this.PbxImagemPessoa = new System.Windows.Forms.PictureBox();
            this.TxtAcesso = new System.Windows.Forms.TextBox();
            this.TxtGraduacao = new System.Windows.Forms.TextBox();
            this.TxtUniversidade = new System.Windows.Forms.TextBox();
            this.TxtCargo = new System.Windows.Forms.TextBox();
            this.TxtNacionalidade = new System.Windows.Forms.TextBox();
            this.LblAcesso = new System.Windows.Forms.Label();
            this.LblGraduacao = new System.Windows.Forms.Label();
            this.LblUniversidade = new System.Windows.Forms.Label();
            this.LblCargo = new System.Windows.Forms.Label();
            this.LblNacionalidade = new System.Windows.Forms.Label();
            this.LblNascido = new System.Windows.Forms.Label();
            this.LblContato = new System.Windows.Forms.Label();
            this.DtpNascido = new System.Windows.Forms.DateTimePicker();
            this.GbxAcao = new System.Windows.Forms.GroupBox();
            this.BtnRealizar = new System.Windows.Forms.Button();
            this.RbtnCadastrar = new System.Windows.Forms.RadioButton();
            this.RbtnPesquisar = new System.Windows.Forms.RadioButton();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.DtgClientes = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.MspMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagemPessoa)).BeginInit();
            this.GbxAcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // MspMenuPrincipal
            // 
            this.MspMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.MspMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MspMenuPrincipal.Name = "MspMenuPrincipal";
            this.MspMenuPrincipal.Size = new System.Drawing.Size(689, 24);
            this.MspMenuPrincipal.TabIndex = 0;
            this.MspMenuPrincipal.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerênciaToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            // 
            // gerênciaToolStripMenuItem
            // 
            this.gerênciaToolStripMenuItem.Name = "gerênciaToolStripMenuItem";
            this.gerênciaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.gerênciaToolStripMenuItem.Text = "Gerência";
            this.gerênciaToolStripMenuItem.Click += new System.EventHandler(this.gerênciaToolStripMenuItem_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSair.Location = new System.Drawing.Point(649, 1);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(40, 23);
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "X";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblListaClientes
            // 
            this.LblListaClientes.AutoSize = true;
            this.LblListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblListaClientes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblListaClientes.Location = new System.Drawing.Point(54, 45);
            this.LblListaClientes.Name = "LblListaClientes";
            this.LblListaClientes.Size = new System.Drawing.Size(112, 17);
            this.LblListaClientes.TabIndex = 2;
            this.LblListaClientes.Text = "Lista de Clientes";
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.BackColor = System.Drawing.SystemColors.GrayText;
            this.TxtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmpresa.Location = new System.Drawing.Point(98, 425);
            this.TxtEmpresa.Multiline = true;
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.Size = new System.Drawing.Size(364, 20);
            this.TxtEmpresa.TabIndex = 10;
            // 
            // LblEmpresa
            // 
            this.LblEmpresa.AutoSize = true;
            this.LblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblEmpresa.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblEmpresa.Location = new System.Drawing.Point(24, 427);
            this.LblEmpresa.Name = "LblEmpresa";
            this.LblEmpresa.Size = new System.Drawing.Size(68, 17);
            this.LblEmpresa.TabIndex = 5;
            this.LblEmpresa.Text = "Empresa:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblNome.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblNome.Location = new System.Drawing.Point(24, 461);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(49, 17);
            this.LblNome.TabIndex = 7;
            this.LblNome.Text = "Nome:";
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.SystemColors.GrayText;
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNome.Location = new System.Drawing.Point(98, 464);
            this.TxtNome.Multiline = true;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(364, 20);
            this.TxtNome.TabIndex = 11;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblCodigo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblCodigo.Location = new System.Drawing.Point(24, 497);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(56, 17);
            this.LblCodigo.TabIndex = 9;
            this.LblCodigo.Text = "Código:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.SystemColors.GrayText;
            this.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCodigo.Location = new System.Drawing.Point(98, 500);
            this.TxtCodigo.Multiline = true;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(58, 20);
            this.TxtCodigo.TabIndex = 12;
            // 
            // BtnOkEmpresa
            // 
            this.BtnOkEmpresa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnOkEmpresa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnOkEmpresa.Location = new System.Drawing.Point(484, 422);
            this.BtnOkEmpresa.Name = "BtnOkEmpresa";
            this.BtnOkEmpresa.Size = new System.Drawing.Size(42, 23);
            this.BtnOkEmpresa.TabIndex = 13;
            this.BtnOkEmpresa.Text = "OK";
            this.BtnOkEmpresa.UseVisualStyleBackColor = false;
            this.BtnOkEmpresa.Click += new System.EventHandler(this.BtnOkEmpresa_Click);
            // 
            // BtnOkNome
            // 
            this.BtnOkNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnOkNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnOkNome.Location = new System.Drawing.Point(484, 459);
            this.BtnOkNome.Name = "BtnOkNome";
            this.BtnOkNome.Size = new System.Drawing.Size(42, 23);
            this.BtnOkNome.TabIndex = 14;
            this.BtnOkNome.Text = "OK";
            this.BtnOkNome.UseVisualStyleBackColor = false;
            this.BtnOkNome.Click += new System.EventHandler(this.BtnOkNome_Click);
            // 
            // BtnOkCodigo
            // 
            this.BtnOkCodigo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnOkCodigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnOkCodigo.Location = new System.Drawing.Point(177, 500);
            this.BtnOkCodigo.Name = "BtnOkCodigo";
            this.BtnOkCodigo.Size = new System.Drawing.Size(42, 23);
            this.BtnOkCodigo.TabIndex = 15;
            this.BtnOkCodigo.Text = "OK";
            this.BtnOkCodigo.UseVisualStyleBackColor = false;
            this.BtnOkCodigo.Click += new System.EventHandler(this.BtnOkCodigo_Click);
            // 
            // PbxImagemPessoa
            // 
            this.PbxImagemPessoa.Image = ((System.Drawing.Image)(resources.GetObject("PbxImagemPessoa.Image")));
            this.PbxImagemPessoa.Location = new System.Drawing.Point(272, 83);
            this.PbxImagemPessoa.Name = "PbxImagemPessoa";
            this.PbxImagemPessoa.Size = new System.Drawing.Size(113, 111);
            this.PbxImagemPessoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImagemPessoa.TabIndex = 14;
            this.PbxImagemPessoa.TabStop = false;
            // 
            // TxtAcesso
            // 
            this.TxtAcesso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAcesso.Location = new System.Drawing.Point(370, 209);
            this.TxtAcesso.Multiline = true;
            this.TxtAcesso.Name = "TxtAcesso";
            this.TxtAcesso.Size = new System.Drawing.Size(55, 18);
            this.TxtAcesso.TabIndex = 3;
            // 
            // TxtGraduacao
            // 
            this.TxtGraduacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtGraduacao.Location = new System.Drawing.Point(370, 244);
            this.TxtGraduacao.Multiline = true;
            this.TxtGraduacao.Name = "TxtGraduacao";
            this.TxtGraduacao.Size = new System.Drawing.Size(117, 18);
            this.TxtGraduacao.TabIndex = 4;
            // 
            // TxtUniversidade
            // 
            this.TxtUniversidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUniversidade.Location = new System.Drawing.Point(370, 278);
            this.TxtUniversidade.Multiline = true;
            this.TxtUniversidade.Name = "TxtUniversidade";
            this.TxtUniversidade.Size = new System.Drawing.Size(154, 18);
            this.TxtUniversidade.TabIndex = 5;
            // 
            // TxtCargo
            // 
            this.TxtCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCargo.Location = new System.Drawing.Point(370, 313);
            this.TxtCargo.Multiline = true;
            this.TxtCargo.Name = "TxtCargo";
            this.TxtCargo.Size = new System.Drawing.Size(154, 18);
            this.TxtCargo.TabIndex = 6;
            // 
            // TxtNacionalidade
            // 
            this.TxtNacionalidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNacionalidade.Location = new System.Drawing.Point(520, 128);
            this.TxtNacionalidade.Multiline = true;
            this.TxtNacionalidade.Name = "TxtNacionalidade";
            this.TxtNacionalidade.Size = new System.Drawing.Size(154, 18);
            this.TxtNacionalidade.TabIndex = 8;
            // 
            // LblAcesso
            // 
            this.LblAcesso.AutoSize = true;
            this.LblAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblAcesso.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblAcesso.Location = new System.Drawing.Point(269, 206);
            this.LblAcesso.Name = "LblAcesso";
            this.LblAcesso.Size = new System.Drawing.Size(58, 17);
            this.LblAcesso.TabIndex = 22;
            this.LblAcesso.Text = "Acesso:";
            // 
            // LblGraduacao
            // 
            this.LblGraduacao.AutoSize = true;
            this.LblGraduacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblGraduacao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblGraduacao.Location = new System.Drawing.Point(269, 241);
            this.LblGraduacao.Name = "LblGraduacao";
            this.LblGraduacao.Size = new System.Drawing.Size(83, 17);
            this.LblGraduacao.TabIndex = 23;
            this.LblGraduacao.Text = "Graduação:";
            // 
            // LblUniversidade
            // 
            this.LblUniversidade.AutoSize = true;
            this.LblUniversidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblUniversidade.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblUniversidade.Location = new System.Drawing.Point(269, 275);
            this.LblUniversidade.Name = "LblUniversidade";
            this.LblUniversidade.Size = new System.Drawing.Size(95, 17);
            this.LblUniversidade.TabIndex = 26;
            this.LblUniversidade.Text = "Universidade:";
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblCargo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblCargo.Location = new System.Drawing.Point(269, 310);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(50, 17);
            this.LblCargo.TabIndex = 28;
            this.LblCargo.Text = "Cargo:";
            // 
            // LblNacionalidade
            // 
            this.LblNacionalidade.AutoSize = true;
            this.LblNacionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblNacionalidade.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblNacionalidade.Location = new System.Drawing.Point(404, 125);
            this.LblNacionalidade.Name = "LblNacionalidade";
            this.LblNacionalidade.Size = new System.Drawing.Size(102, 17);
            this.LblNacionalidade.TabIndex = 29;
            this.LblNacionalidade.Text = "Nacionalidade:";
            // 
            // LblNascido
            // 
            this.LblNascido.AutoSize = true;
            this.LblNascido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblNascido.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblNascido.Location = new System.Drawing.Point(409, 83);
            this.LblNascido.Name = "LblNascido";
            this.LblNascido.Size = new System.Drawing.Size(86, 17);
            this.LblNascido.TabIndex = 30;
            this.LblNascido.Text = "Nascido em:";
            // 
            // LblContato
            // 
            this.LblContato.AutoSize = true;
            this.LblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblContato.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblContato.Location = new System.Drawing.Point(434, 166);
            this.LblContato.Name = "LblContato";
            this.LblContato.Size = new System.Drawing.Size(61, 17);
            this.LblContato.TabIndex = 31;
            this.LblContato.Text = "Contato:";
            // 
            // DtpNascido
            // 
            this.DtpNascido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpNascido.Location = new System.Drawing.Point(520, 80);
            this.DtpNascido.Name = "DtpNascido";
            this.DtpNascido.Size = new System.Drawing.Size(88, 20);
            this.DtpNascido.TabIndex = 7;
            // 
            // GbxAcao
            // 
            this.GbxAcao.Controls.Add(this.BtnRealizar);
            this.GbxAcao.Controls.Add(this.RbtnCadastrar);
            this.GbxAcao.Controls.Add(this.RbtnPesquisar);
            this.GbxAcao.Location = new System.Drawing.Point(540, 397);
            this.GbxAcao.Name = "GbxAcao";
            this.GbxAcao.Size = new System.Drawing.Size(137, 126);
            this.GbxAcao.TabIndex = 18;
            this.GbxAcao.TabStop = false;
            this.GbxAcao.Text = "Ação";
            // 
            // BtnRealizar
            // 
            this.BtnRealizar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnRealizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnRealizar.Location = new System.Drawing.Point(35, 88);
            this.BtnRealizar.Name = "BtnRealizar";
            this.BtnRealizar.Size = new System.Drawing.Size(68, 29);
            this.BtnRealizar.TabIndex = 15;
            this.BtnRealizar.Text = "Realizar";
            this.BtnRealizar.UseVisualStyleBackColor = false;
            this.BtnRealizar.Click += new System.EventHandler(this.BtnRealizar_Click);
            // 
            // RbtnCadastrar
            // 
            this.RbtnCadastrar.AutoSize = true;
            this.RbtnCadastrar.Location = new System.Drawing.Point(33, 55);
            this.RbtnCadastrar.Name = "RbtnCadastrar";
            this.RbtnCadastrar.Size = new System.Drawing.Size(70, 17);
            this.RbtnCadastrar.TabIndex = 16;
            this.RbtnCadastrar.TabStop = true;
            this.RbtnCadastrar.Text = "Cadastrar";
            this.RbtnCadastrar.UseVisualStyleBackColor = true;
            // 
            // RbtnPesquisar
            // 
            this.RbtnPesquisar.AutoSize = true;
            this.RbtnPesquisar.Location = new System.Drawing.Point(19, 32);
            this.RbtnPesquisar.Name = "RbtnPesquisar";
            this.RbtnPesquisar.Size = new System.Drawing.Size(71, 17);
            this.RbtnPesquisar.TabIndex = 17;
            this.RbtnPesquisar.TabStop = true;
            this.RbtnPesquisar.Text = "Pesquisar";
            this.RbtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Location = new System.Drawing.Point(289, 364);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnAtualizar.TabIndex = 32;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(370, 364);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 33;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Location = new System.Drawing.Point(451, 364);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(75, 23);
            this.BtnDeletar.TabIndex = 34;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(520, 166);
            this.maskedTextBox1.Mask = "000 (99) 00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(154, 20);
            this.maskedTextBox1.TabIndex = 35;
            // 
            // DtgClientes
            // 
            this.DtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgClientes.Location = new System.Drawing.Point(0, 65);
            this.DtgClientes.Name = "DtgClientes";
            this.DtgClientes.Size = new System.Drawing.Size(219, 359);
            this.DtgClientes.TabIndex = 36;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Enabled = false;
            this.txtPesquisa.Location = new System.Drawing.Point(345, 503);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisa.TabIndex = 37;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(265, 507);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(74, 13);
            this.lblPesquisa.TabIndex = 38;
            this.lblPesquisa.Text = "Pesquisar por:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(689, 532);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.DtgClientes);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.GbxAcao);
            this.Controls.Add(this.DtpNascido);
            this.Controls.Add(this.LblContato);
            this.Controls.Add(this.LblNascido);
            this.Controls.Add(this.LblNacionalidade);
            this.Controls.Add(this.LblCargo);
            this.Controls.Add(this.LblUniversidade);
            this.Controls.Add(this.LblGraduacao);
            this.Controls.Add(this.LblAcesso);
            this.Controls.Add(this.TxtNacionalidade);
            this.Controls.Add(this.TxtCargo);
            this.Controls.Add(this.TxtUniversidade);
            this.Controls.Add(this.TxtGraduacao);
            this.Controls.Add(this.TxtAcesso);
            this.Controls.Add(this.PbxImagemPessoa);
            this.Controls.Add(this.BtnOkCodigo);
            this.Controls.Add(this.BtnOkNome);
            this.Controls.Add(this.BtnOkEmpresa);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblEmpresa);
            this.Controls.Add(this.TxtEmpresa);
            this.Controls.Add(this.LblListaClientes);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.MspMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MspMenuPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
            this.MspMenuPrincipal.ResumeLayout(false);
            this.MspMenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagemPessoa)).EndInit();
            this.GbxAcao.ResumeLayout(false);
            this.GbxAcao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MspMenuPrincipal;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblListaClientes;
        private System.Windows.Forms.TextBox TxtEmpresa;
        private System.Windows.Forms.Label LblEmpresa;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button BtnOkEmpresa;
        private System.Windows.Forms.Button BtnOkNome;
        private System.Windows.Forms.Button BtnOkCodigo;
        private System.Windows.Forms.PictureBox PbxImagemPessoa;
        private System.Windows.Forms.TextBox TxtAcesso;
        private System.Windows.Forms.TextBox TxtGraduacao;
        private System.Windows.Forms.TextBox TxtUniversidade;
        private System.Windows.Forms.TextBox TxtCargo;
        private System.Windows.Forms.TextBox TxtNacionalidade;
        private System.Windows.Forms.Label LblAcesso;
        private System.Windows.Forms.Label LblGraduacao;
        private System.Windows.Forms.Label LblUniversidade;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.Label LblNacionalidade;
        private System.Windows.Forms.Label LblNascido;
        private System.Windows.Forms.Label LblContato;
        private System.Windows.Forms.DateTimePicker DtpNascido;
        private System.Windows.Forms.GroupBox GbxAcao;
        private System.Windows.Forms.Button BtnRealizar;
        private System.Windows.Forms.RadioButton RbtnCadastrar;
        private System.Windows.Forms.RadioButton RbtnPesquisar;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridView DtgClientes;
        private System.Windows.Forms.ToolStripMenuItem gerênciaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
    }
}