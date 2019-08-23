namespace JBMD_4Bimestre
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.MtpMenu = new System.Windows.Forms.MenuStrip();
            this.SmiSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblIncompativel = new System.Windows.Forms.Label();
            this.PbxCirculoUsuario = new System.Windows.Forms.PictureBox();
            this.PbxCirculoSenha = new System.Windows.Forms.PictureBox();
            this.gerênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MtpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCirculoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCirculoSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // MtpMenu
            // 
            this.MtpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmiSobre});
            this.MtpMenu.Location = new System.Drawing.Point(0, 0);
            this.MtpMenu.Name = "MtpMenu";
            this.MtpMenu.Size = new System.Drawing.Size(572, 24);
            this.MtpMenu.TabIndex = 0;
            this.MtpMenu.Text = "menuStrip1";
            // 
            // SmiSobre
            // 
            this.SmiSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerênciaToolStripMenuItem});
            this.SmiSobre.Name = "SmiSobre";
            this.SmiSobre.Size = new System.Drawing.Size(58, 20);
            this.SmiSobre.Text = "Sobre...";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(543, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(29, 23);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "X";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblUsuario.Location = new System.Drawing.Point(145, 105);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(72, 18);
            this.LblUsuario.TabIndex = 4;
            this.LblUsuario.Text = "Usuário:";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.BackColor = System.Drawing.Color.Transparent;
            this.LblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblSenha.Location = new System.Drawing.Point(157, 143);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(60, 18);
            this.LblSenha.TabIndex = 5;
            this.LblSenha.Text = "Senha:";
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVerificar.Location = new System.Drawing.Point(259, 220);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(59, 23);
            this.BtnVerificar.TabIndex = 3;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // TxtSenha
            // 
            this.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSenha.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(223, 147);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(154, 19);
            this.TxtSenha.TabIndex = 2;
            this.TxtSenha.TextChanged += new System.EventHandler(this.TxtSenha_TextChanged);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(223, 105);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(154, 19);
            this.TxtUsuario.TabIndex = 1;
            // 
            // LblIncompativel
            // 
            this.LblIncompativel.AutoSize = true;
            this.LblIncompativel.BackColor = System.Drawing.Color.Transparent;
            this.LblIncompativel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIncompativel.ForeColor = System.Drawing.Color.Gold;
            this.LblIncompativel.Location = new System.Drawing.Point(243, 246);
            this.LblIncompativel.Name = "LblIncompativel";
            this.LblIncompativel.Size = new System.Drawing.Size(91, 15);
            this.LblIncompativel.TabIndex = 9;
            this.LblIncompativel.Text = "Incompatível";
            this.LblIncompativel.Visible = false;
            // 
            // PbxCirculoUsuario
            // 
            this.PbxCirculoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.PbxCirculoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("PbxCirculoUsuario.Image")));
            this.PbxCirculoUsuario.Location = new System.Drawing.Point(383, 105);
            this.PbxCirculoUsuario.Name = "PbxCirculoUsuario";
            this.PbxCirculoUsuario.Size = new System.Drawing.Size(26, 18);
            this.PbxCirculoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxCirculoUsuario.TabIndex = 10;
            this.PbxCirculoUsuario.TabStop = false;
            this.PbxCirculoUsuario.Visible = false;
            // 
            // PbxCirculoSenha
            // 
            this.PbxCirculoSenha.BackColor = System.Drawing.Color.Transparent;
            this.PbxCirculoSenha.Image = ((System.Drawing.Image)(resources.GetObject("PbxCirculoSenha.Image")));
            this.PbxCirculoSenha.Location = new System.Drawing.Point(383, 149);
            this.PbxCirculoSenha.Name = "PbxCirculoSenha";
            this.PbxCirculoSenha.Size = new System.Drawing.Size(26, 18);
            this.PbxCirculoSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxCirculoSenha.TabIndex = 11;
            this.PbxCirculoSenha.TabStop = false;
            this.PbxCirculoSenha.Visible = false;
            // 
            // gerênciaToolStripMenuItem
            // 
            this.gerênciaToolStripMenuItem.Name = "gerênciaToolStripMenuItem";
            this.gerênciaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gerênciaToolStripMenuItem.Text = "Gerência";
            this.gerênciaToolStripMenuItem.Click += new System.EventHandler(this.gerênciaToolStripMenuItem_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 305);
            this.Controls.Add(this.PbxCirculoSenha);
            this.Controls.Add(this.PbxCirculoUsuario);
            this.Controls.Add(this.LblIncompativel);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.MtpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MtpMenu;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.MtpMenu.ResumeLayout(false);
            this.MtpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCirculoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCirculoSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MtpMenu;
        private System.Windows.Forms.ToolStripMenuItem SmiSobre;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblIncompativel;
        private System.Windows.Forms.PictureBox PbxCirculoUsuario;
        private System.Windows.Forms.PictureBox PbxCirculoSenha;
        private System.Windows.Forms.ToolStripMenuItem gerênciaToolStripMenuItem;
    }
}