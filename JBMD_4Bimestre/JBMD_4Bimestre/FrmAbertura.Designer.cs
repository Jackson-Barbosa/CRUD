namespace JBMD_4Bimestre
{
    partial class FrmAbertura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbertura));
            this.PbxAbertura = new System.Windows.Forms.PictureBox();
            this.TmrContador = new System.Windows.Forms.Timer(this.components);
            this.lblNomes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAbertura)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxAbertura
            // 
            this.PbxAbertura.BackColor = System.Drawing.Color.Transparent;
            this.PbxAbertura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PbxAbertura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxAbertura.Image = ((System.Drawing.Image)(resources.GetObject("PbxAbertura.Image")));
            this.PbxAbertura.Location = new System.Drawing.Point(0, 0);
            this.PbxAbertura.Name = "PbxAbertura";
            this.PbxAbertura.Size = new System.Drawing.Size(682, 498);
            this.PbxAbertura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxAbertura.TabIndex = 0;
            this.PbxAbertura.TabStop = false;
            // 
            // TmrContador
            // 
            this.TmrContador.Tick += new System.EventHandler(this.TmrContador_Tick);
            // 
            // lblNomes
            // 
            this.lblNomes.AutoSize = true;
            this.lblNomes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomes.Location = new System.Drawing.Point(12, 464);
            this.lblNomes.Name = "lblNomes";
            this.lblNomes.Size = new System.Drawing.Size(656, 25);
            this.lblNomes.TabIndex = 2;
            this.lblNomes.Text = "  Jackson Barbosa e Mariana Duarte, estudantes do IFSP-Cubatão.";
            // 
            // FrmAbertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(682, 498);
            this.Controls.Add(this.lblNomes);
            this.Controls.Add(this.PbxAbertura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAbertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PbxAbertura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxAbertura;
        private System.Windows.Forms.Timer TmrContador;
        private System.Windows.Forms.Label lblNomes;
    }
}

