namespace AirSystem.Views
{
    partial class frmLogadoComum
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
            this.btnListaAvioes = new System.Windows.Forms.Button();
            this.btnGerenciarAviao = new System.Windows.Forms.Button();
            this.btnGerenciarCompanhia = new System.Windows.Forms.Button();
            this.btnGerenciarRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListaAvioes
            // 
            this.btnListaAvioes.Location = new System.Drawing.Point(227, 89);
            this.btnListaAvioes.Name = "btnListaAvioes";
            this.btnListaAvioes.Size = new System.Drawing.Size(98, 65);
            this.btnListaAvioes.TabIndex = 0;
            this.btnListaAvioes.Text = "Listar Aviões";
            this.btnListaAvioes.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarAviao
            // 
            this.btnGerenciarAviao.Location = new System.Drawing.Point(434, 89);
            this.btnGerenciarAviao.Name = "btnGerenciarAviao";
            this.btnGerenciarAviao.Size = new System.Drawing.Size(98, 65);
            this.btnGerenciarAviao.TabIndex = 1;
            this.btnGerenciarAviao.Text = "Gerenciar Avião";
            this.btnGerenciarAviao.UseVisualStyleBackColor = true;
            this.btnGerenciarAviao.Click += new System.EventHandler(this.btnGerenciarAviao_Click);
            // 
            // btnGerenciarCompanhia
            // 
            this.btnGerenciarCompanhia.Location = new System.Drawing.Point(227, 259);
            this.btnGerenciarCompanhia.Name = "btnGerenciarCompanhia";
            this.btnGerenciarCompanhia.Size = new System.Drawing.Size(98, 65);
            this.btnGerenciarCompanhia.TabIndex = 2;
            this.btnGerenciarCompanhia.Text = "Gerenciar Companhia";
            this.btnGerenciarCompanhia.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarRelatorios
            // 
            this.btnGerenciarRelatorios.Location = new System.Drawing.Point(434, 259);
            this.btnGerenciarRelatorios.Name = "btnGerenciarRelatorios";
            this.btnGerenciarRelatorios.Size = new System.Drawing.Size(98, 65);
            this.btnGerenciarRelatorios.TabIndex = 3;
            this.btnGerenciarRelatorios.Text = "Gerenciar Relatorios";
            this.btnGerenciarRelatorios.UseVisualStyleBackColor = true;
            // 
            // frmLogadoComum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerenciarRelatorios);
            this.Controls.Add(this.btnGerenciarCompanhia);
            this.Controls.Add(this.btnGerenciarAviao);
            this.Controls.Add(this.btnListaAvioes);
            this.Name = "frmLogadoComum";
            this.Text = "frmLogado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaAvioes;
        private System.Windows.Forms.Button btnGerenciarAviao;
        private System.Windows.Forms.Button btnGerenciarCompanhia;
        private System.Windows.Forms.Button btnGerenciarRelatorios;
    }
}