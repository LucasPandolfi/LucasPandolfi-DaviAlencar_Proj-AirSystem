using AirSystem.Models;
using AirSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class frmListarUsuario : Form
    {
        UsuarioRepository repository = new UsuarioRepository();

        public frmListarUsuario()
        {
            InitializeComponent();
        }

        private void frmListaUsuario_Load(object sender, EventArgs e)
        {
            carregaLista();
        }

        private void dgvListarUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow linha = dgvListarUsuarios.Rows[e.RowIndex];

            string Nome = linha.Cells[1].Value.ToString();
            string Sobrenome = linha.Cells[2].Value.ToString();
            string Endereco = linha.Cells[3].Value.ToString();
            string Numero = linha.Cells[4].Value.ToString();
            string Nascimento = linha.Cells[5].Value.ToString();
            string NomeUsuario = linha.Cells[6].Value.ToString();
            string Senha = linha.Cells[7].Value.ToString();
            string ConfirmarSenha = linha.Cells[8].Value.ToString();

            Usuario usuario = new Usuario
            {
                Nome = Nome,
                Sobrenome = Sobrenome,
                Endereco = Endereco,
                Numero = Numero,
                Nascimento = Nascimento,
                NomeUsuario = NomeUsuario,
                Senha = Senha,
                ConfirmarSenha = ConfirmarSenha
            };

            new frmCadastro(usuario).ShowDialog();

            carregaLista();
        }

        private void dgvListarUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dr = MessageBox.Show("Deseja excluir este usuário?", "Atenção"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow linha = dgvListarUsuarios.Rows[e.RowIndex];

                    int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());

                    repository.deletar(codigo);

                    carregaLista();
                }
            }
        }

        private void carregaLista()
        {
            UsuarioRepository repository = new UsuarioRepository();
            dgvListarUsuarios.DataSource = null;
            dgvListarUsuarios.DataSource = repository.BuscarTodos();
            alterarId();
        }

        private void alterarId()
        {
            lbl_Id.Text = $"{dgvListarUsuarios.RowCount} itens de {repository.BuscarTodos().Count}";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
            
            carregaLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();

            
        }

        private void FiltroNomeTextBox_TextChanged(object sender, EventArgs e)
        {
            dgvListarUsuarios.DataSource = null;

            dgvListarUsuarios.DataSource = repository.BuscarTodos().FindAll(x =>
                x.Nome.ToUpper().Contains(FiltroNomeTextBox.Text.ToUpper()) ||
                x.Sobrenome.ToUpper().Contains(FiltroNomeTextBox.Text.ToUpper())
            );

            alterarId();
        }
    }
}
