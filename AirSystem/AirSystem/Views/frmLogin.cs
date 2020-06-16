using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txbSenha.ShortcutsEnabled = false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txbUsuario.Text.Trim().Length == 0 || txbSenha.Text.Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Digite o usuário e a senha.", "Erro");                               
            }         
            else
            {
                MessageBox.Show("Bem Vindo(a)", "Entrada");
                new frmLogadoAdmin().ShowDialog();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }

        private void btnUsuarioComum_Click(object sender, EventArgs e)
        {
            new frmLogadoComum().ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.RelogioDigital.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
