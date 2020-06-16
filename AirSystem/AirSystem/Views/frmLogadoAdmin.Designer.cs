namespace AirSystem.Views
{
    partial class frmLogadoAdmin
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
            this.btnListarUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListaAvioes
            // 
            this.btnListaAvioes.Location = new System.Drawing.Point(198, 99);
            this.btnListaAvioes.Name = "btnListaAvioes";
            this.btnListaAvioes.Size = new System.Drawing.Size(98, 65);
            this.btnListaAvioes.TabIndex = 1;
            this.btnListaAvioes.Text = "Listar Aviões";
            this.btnListaAvioes.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarAviao
            // 
            this.btnGerenciarAviao.Location = new System.Drawing.Point(494, 99);
            this.btnGerenciarAviao.Name = "btnGerenciarAviao";
            this.btnGerenciarAviao.Size = new System.Drawing.Size(98, 65);
            this.btnGerenciarAviao.TabIndex = 2;
            this.btnGerenciarAviao.Text = "Gerenciar Avião";
            this.btnGerenciarAviao.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarCompanhia
            // 
            this.btnGerenciarCompanhia.Location = new System.Drawing.Point(244, 232);
            this.btnGerenciarCompanhia.Name = "btnGerenciarCompanhia";
            this.btnGerenciarCompanhia.Size = new System.Drawing.Size(98, 65);
            this.btnGerenciarCompanhia.TabIndex = 3;
            this.btnGerenciarCompanhia.Text = "Gerenciar Companhia";
            this.btnGerenciarCompanhia.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarRelatorios
            // 
            this.btnGerenciarRelatorios.Location = new System.Drawing.Point(437, 232);
            this.btnGerenciarRelatorios.Name = "btnGerenciarRelatorios";
            this.btnGerenciarRelatorios.Size = new System.Drawing.Size(98, 65);
            this.btnGerenciarRelatorios.TabIndex = 4;
            this.btnGerenciarRelatorios.Text = "Gerenciar Relatorios";
            this.btnGerenciarRelatorios.UseVisualStyleBackColor = true;
            // 
            // btnListarUsuarios
            // 
            this.btnListarUsuarios.Location = new System.Drawing.Point(346, 99);
            this.btnListarUsuarios.Name = "btnListarUsuarios";
            this.btnListarUsuarios.Size = new System.Drawing.Size(98, 65);
            this.btnListarUsuarios.TabIndex = 5;
            this.btnListarUsuarios.Text = "Listar Usuarios";
            this.btnListarUsuarios.UseVisualStyleBackColor = true;
            this.btnListarUsuarios.Click += new System.EventHandler(this.btnListarUsuarios_Click);
            // 
            // frmLogadoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarUsuarios);
            this.Controls.Add(this.btnGerenciarRelatorios);
            this.Controls.Add(this.btnGerenciarCompanhia);
            this.Controls.Add(this.btnGerenciarAviao);
            this.Controls.Add(this.btnListaAvioes);
            this.Name = "frmLogadoAdmin";
            this.Text = "frmLogadoAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaAvioes;
        private System.Windows.Forms.Button btnGerenciarAviao;
        private System.Windows.Forms.Button btnGerenciarCompanhia;
        private System.Windows.Forms.Button btnGerenciarRelatorios;
        private System.Windows.Forms.Button btnListarUsuarios;
    }
}