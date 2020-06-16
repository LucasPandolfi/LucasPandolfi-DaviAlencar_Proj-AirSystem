using AirSystem.Models;
using AirSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class frmCadastro : Form
    {
        private Usuario usuario = null;
        public frmCadastro()
        {
            InitializeComponent();
        }
        public frmCadastro(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
        }
        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                NomeTextBox.Text = usuario.Nome;
                SobrenomeTextBox.Text = usuario.Sobrenome;
                EnderecoTextBox.Text = usuario.Endereco;
                NumeroTextBox.Text = usuario.Numero;
                NascimentoDateTimePicker.Text = usuario.Nascimento;
                UsuarioTextBox.Text = usuario.NomeUsuario;
                SenhaTextBox.Text = usuario.Senha;
                ConfirmarSenhaTextBox.Text = usuario.ConfirmarSenha;
                AdminCheckBox.Checked = usuario.admin;
            }
        }

        private void btnAlterarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog AlterarImagem = new OpenFileDialog();

            AlterarImagem.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";

            if (AlterarImagem.ShowDialog() == DialogResult.OK)
            {
                FotopictureBox1.Image = Image.FromFile(AlterarImagem.FileName);
            }
        }

        private void btnRemoverFoto_Click(object sender, EventArgs e)
        {
            if (FotopictureBox1.Image != null)
            {
                FotopictureBox1.Image.Dispose();
                FotopictureBox1.Image = null;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(!Utils.TemCamposVazio(this))
            {
                UsuarioRepository repository = new UsuarioRepository();
                if (this.usuario == null)
                {
                    Usuario usuario = new Usuario
                    {
                        Nome = NomeTextBox.Text,
                        Sobrenome = SobrenomeTextBox.Text,
                        Endereco = EnderecoTextBox.Text,
                        Numero = NumeroTextBox.Text,
                        Nascimento = NascimentoDateTimePicker.Text,
                        NomeUsuario = NomeTextBox.Text,
                        Senha = SenhaTextBox.Text,
                        ConfirmarSenha = ConfirmarSenhaTextBox.Text,
                        admin = AdminCheckBox.Checked
                    };
                    
                    repository.Adicionar(usuario);
                   
                    MessageBox.Show("Dados Salvos.",
                                    "Aviso", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }
                else
                {
                    this.usuario.Nome = NomeTextBox.Text;
                    this.usuario.Sobrenome = SobrenomeTextBox.Text;
                    this.usuario.Endereco = EnderecoTextBox.Text;
                    this.usuario.Numero = NumeroTextBox.Text;
                    this.usuario.Nascimento = NascimentoDateTimePicker.Text;
                    this.usuario.NomeUsuario = UsuarioTextBox.Text;
                    this.usuario.Senha = SenhaTextBox.Text;
                    this.usuario.ConfirmarSenha = ConfirmarSenhaTextBox.Text;
                    this.usuario.admin = AdminCheckBox.Checked;

                    repository.Editar(usuario);
                }
                this.Close();
            }
            else
            {  
                MessageBox.Show("Todos os campos são obrigatórios.",
                                "Aviso", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }            
        }

        bool ValidaSenha;
        private void SenhaTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = "[A-Z]{1,}[a-z]{1,}[1-9]{1,}";

            ValidaSenha = !Regex.IsMatch(SenhaTextBox.Text, pattern);
        }

        private void NascimentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            
            dateTimePicker1.Value = DateTime.Now.AddDays(1);        
        }

        private void ConfirmarSenhaTextBox_TextChanged(object sender, EventArgs e)
        {
            _ = SenhaTextBox.Text == ConfirmarSenhaTextBox.Text ? lblSenhasIguais.Visible = false : lblSenhasIguais.Visible = true;
        }
    }
}
