namespace ProjetoCatAPI
{
    partial class FrmGerador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerador));
            this.pbGato = new System.Windows.Forms.PictureBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.rdbCachorro = new System.Windows.Forms.RadioButton();
            this.rdbGato = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbGato)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGato
            // 
            this.pbGato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGato.Location = new System.Drawing.Point(12, 12);
            this.pbGato.Name = "pbGato";
            this.pbGato.Size = new System.Drawing.Size(382, 271);
            this.pbGato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGato.TabIndex = 0;
            this.pbGato.TabStop = false;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(163, 322);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // rdbCachorro
            // 
            this.rdbCachorro.AutoSize = true;
            this.rdbCachorro.Location = new System.Drawing.Point(135, 289);
            this.rdbCachorro.Name = "rdbCachorro";
            this.rdbCachorro.Size = new System.Drawing.Size(68, 17);
            this.rdbCachorro.TabIndex = 2;
            this.rdbCachorro.TabStop = true;
            this.rdbCachorro.Text = "Cachorro";
            this.rdbCachorro.UseVisualStyleBackColor = true;
            // 
            // rdbGato
            // 
            this.rdbGato.AutoSize = true;
            this.rdbGato.Location = new System.Drawing.Point(221, 289);
            this.rdbGato.Name = "rdbGato";
            this.rdbGato.Size = new System.Drawing.Size(48, 17);
            this.rdbGato.TabIndex = 3;
            this.rdbGato.TabStop = true;
            this.rdbGato.Text = "Gato";
            this.rdbGato.UseVisualStyleBackColor = true;
            // 
            // FrmGerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 357);
            this.Controls.Add(this.rdbGato);
            this.Controls.Add(this.rdbCachorro);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.pbGato);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGerador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de bichinhos";
            ((System.ComponentModel.ISupportInitialize)(this.pbGato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGato;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.RadioButton rdbCachorro;
        private System.Windows.Forms.RadioButton rdbGato;
    }
}

