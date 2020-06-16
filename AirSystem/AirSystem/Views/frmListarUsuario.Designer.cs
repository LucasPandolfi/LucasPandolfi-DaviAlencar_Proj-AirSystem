namespace AirSystem.Views
{
    partial class frmListarUsuario
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
            this.dgvListarUsuarios = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.FiltroNomeTextBox = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarUsuarios
            // 
            this.dgvListarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarUsuarios.Location = new System.Drawing.Point(15, 32);
            this.dgvListarUsuarios.Name = "dgvListarUsuarios";
            this.dgvListarUsuarios.Size = new System.Drawing.Size(654, 327);
            this.dgvListarUsuarios.TabIndex = 0;
            this.dgvListarUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarUsuarios_CellContentClick);
            this.dgvListarUsuarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarUsuarios_CellMouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nome:";
            // 
            // FiltroNomeTextBox
            // 
            this.FiltroNomeTextBox.Location = new System.Drawing.Point(60, 6);
            this.FiltroNomeTextBox.Name = "FiltroNomeTextBox";
            this.FiltroNomeTextBox.Size = new System.Drawing.Size(163, 20);
            this.FiltroNomeTextBox.TabIndex = 21;
            this.FiltroNomeTextBox.TextChanged += new System.EventHandler(this.FiltroNomeTextBox_TextChanged);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(675, 346);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(41, 13);
            this.lbl_Id.TabIndex = 22;
            this.lbl_Id.Text = "label10";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(676, 32);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(676, 90);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.FiltroNomeTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvListarUsuarios);
            this.Name = "frmListarUsuario";
            this.Text = "frmListarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarUsuarios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FiltroNomeTextBox;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
    }
}