namespace AirSystem.Views
{
    partial class frmCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SobrenomeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EnderecoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SenhaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ConfirmarSenhaTextBox = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterarFoto = new System.Windows.Forms.Button();
            this.btnRemoverFoto = new System.Windows.Forms.Button();
            this.AdminCheckBox = new System.Windows.Forms.CheckBox();
            this.FotopictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSenhasIguais = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FotopictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(28, 37);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(122, 20);
            this.NomeTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sobrenome";
            // 
            // SobrenomeTextBox
            // 
            this.SobrenomeTextBox.Location = new System.Drawing.Point(178, 37);
            this.SobrenomeTextBox.Name = "SobrenomeTextBox";
            this.SobrenomeTextBox.Size = new System.Drawing.Size(122, 20);
            this.SobrenomeTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço";
            // 
            // EnderecoTextBox
            // 
            this.EnderecoTextBox.Location = new System.Drawing.Point(28, 93);
            this.EnderecoTextBox.Name = "EnderecoTextBox";
            this.EnderecoTextBox.Size = new System.Drawing.Size(165, 20);
            this.EnderecoTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "N*";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(220, 93);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(80, 20);
            this.NumeroTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nascimento";
            // 
            // NascimentoDateTimePicker
            // 
            this.NascimentoDateTimePicker.Checked = false;
            this.NascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NascimentoDateTimePicker.Location = new System.Drawing.Point(28, 151);
            this.NascimentoDateTimePicker.Name = "NascimentoDateTimePicker";
            this.NascimentoDateTimePicker.Size = new System.Drawing.Size(272, 20);
            this.NascimentoDateTimePicker.TabIndex = 10;
            this.NascimentoDateTimePicker.ValueChanged += new System.EventHandler(this.NascimentoDateTimePicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Usuario";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(28, 209);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(272, 20);
            this.UsuarioTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Senha";
            // 
            // SenhaTextBox
            // 
            this.SenhaTextBox.Location = new System.Drawing.Point(28, 268);
            this.SenhaTextBox.MaxLength = 16;
            this.SenhaTextBox.Name = "SenhaTextBox";
            this.SenhaTextBox.PasswordChar = '*';
            this.SenhaTextBox.Size = new System.Drawing.Size(272, 20);
            this.SenhaTextBox.TabIndex = 14;
            this.SenhaTextBox.TextChanged += new System.EventHandler(this.SenhaTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Confirmar senha";
            // 
            // ConfirmarSenhaTextBox
            // 
            this.ConfirmarSenhaTextBox.Location = new System.Drawing.Point(28, 328);
            this.ConfirmarSenhaTextBox.MaxLength = 16;
            this.ConfirmarSenhaTextBox.Name = "ConfirmarSenhaTextBox";
            this.ConfirmarSenhaTextBox.PasswordChar = '*';
            this.ConfirmarSenhaTextBox.Size = new System.Drawing.Size(272, 20);
            this.ConfirmarSenhaTextBox.TabIndex = 14;
            this.ConfirmarSenhaTextBox.TextChanged += new System.EventHandler(this.ConfirmarSenhaTextBox_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(90, 379);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(146, 23);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterarFoto
            // 
            this.btnAlterarFoto.Location = new System.Drawing.Point(603, 193);
            this.btnAlterarFoto.Name = "btnAlterarFoto";
            this.btnAlterarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarFoto.TabIndex = 19;
            this.btnAlterarFoto.Text = "Alterar";
            this.btnAlterarFoto.UseVisualStyleBackColor = true;
            this.btnAlterarFoto.Click += new System.EventHandler(this.btnAlterarFoto_Click);
            // 
            // btnRemoverFoto
            // 
            this.btnRemoverFoto.Location = new System.Drawing.Point(713, 193);
            this.btnRemoverFoto.Name = "btnRemoverFoto";
            this.btnRemoverFoto.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverFoto.TabIndex = 20;
            this.btnRemoverFoto.Text = "Remover";
            this.btnRemoverFoto.UseVisualStyleBackColor = true;
            this.btnRemoverFoto.Click += new System.EventHandler(this.btnRemoverFoto_Click);
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.AutoSize = true;
            this.AdminCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCheckBox.Location = new System.Drawing.Point(653, 241);
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.Size = new System.Drawing.Size(86, 24);
            this.AdminCheckBox.TabIndex = 21;
            this.AdminCheckBox.Text = "É admin";
            this.AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // FotopictureBox1
            // 
            this.FotopictureBox1.Image = global::AirSystem.Properties.Resources.vector_profile_glyph_black_icon;
            this.FotopictureBox1.Location = new System.Drawing.Point(603, 37);
            this.FotopictureBox1.Name = "FotopictureBox1";
            this.FotopictureBox1.Size = new System.Drawing.Size(185, 150);
            this.FotopictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotopictureBox1.TabIndex = 22;
            this.FotopictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(600, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Escolha uma foto de perfil";
            // 
            // lblSenhasIguais
            // 
            this.lblSenhasIguais.AutoSize = true;
            this.lblSenhasIguais.BackColor = System.Drawing.Color.White;
            this.lblSenhasIguais.ForeColor = System.Drawing.Color.Red;
            this.lblSenhasIguais.Location = new System.Drawing.Point(306, 328);
            this.lblSenhasIguais.Name = "lblSenhasIguais";
            this.lblSenhasIguais.Size = new System.Drawing.Size(113, 13);
            this.lblSenhasIguais.TabIndex = 24;
            this.lblSenhasIguais.Text = "A senha esta diferente";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSenhasIguais);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FotopictureBox1);
            this.Controls.Add(this.AdminCheckBox);
            this.Controls.Add(this.btnRemoverFoto);
            this.Controls.Add(this.btnAlterarFoto);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.ConfirmarSenhaTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SenhaTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NascimentoDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnderecoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SobrenomeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.FotopictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SobrenomeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EnderecoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker NascimentoDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SenhaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ConfirmarSenhaTextBox;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterarFoto;
        private System.Windows.Forms.Button btnRemoverFoto;
        private System.Windows.Forms.CheckBox AdminCheckBox;
        private System.Windows.Forms.PictureBox FotopictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSenhasIguais;
    }
}