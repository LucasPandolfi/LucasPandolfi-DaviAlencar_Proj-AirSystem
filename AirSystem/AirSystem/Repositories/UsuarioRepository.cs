using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Repositories
{
    class UsuarioRepository
    {
        //criando uma lista static para carregar o usuario no DataGrid
        private static List<Usuario> usuarios;

        //contador do id dos usuarios
        private static int id = 1;

        //contrutor do repository
        public UsuarioRepository()
        {
            if(usuarios == null)
            {
                usuarios = new List<Usuario>();

                //Adicionar usuario para facilitar nos metodos de excluir e editar
                usuarios.Add(new Usuario
                {
                    Id = 1,
                    Nome = "Lucas",
                    Sobrenome = "Pandolfi",
                    Endereco = "Rua Brasilio",
                    Numero = "38",
                    Nascimento = Convert.ToString("11/02/2001"),
                    NomeUsuario = "LucasPandolfi",
                    Senha = "Aa123",
                    ConfirmarSenha = "Aa123",
                    admin = true
                });
                id++;
                usuarios.Add(new Usuario
                {
                    Id = 2,
                    Nome = "Victor",
                    Sobrenome = "Pandolfi",
                    Endereco = "Rua Brasilio",
                    Numero = "39",
                    Nascimento = Convert.ToString("25/05/1996"),
                    NomeUsuario = "VictorPandolfi",
                    Senha = "Aa123",
                    ConfirmarSenha = "Aa123",
                    admin = false
                });
                id++;
            }
        }

        //metodo responsavel por listar usuarios
        public List<Usuario> BuscarTodos()
        {
            return usuarios;
        }

        //metodo responsavel por adicionar usuarios
        public void Adicionar(Usuario usuario)
        {
            usuario.Id = id;

            usuarios.Add(usuario);
            id++;
        }

        //metodo responsavel para Editar usuarios
        public void Editar(Usuario usuario)
        {
            Usuario u = usuarios.Find(x => x.Id == usuario.Id);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }

        //metodo responsavel por excluir usuarios
        public void deletar(int codigo)
        {
            Usuario usuario = usuarios.Find(x => x.Id == codigo);

            usuarios.Remove(usuario);
        }
    }
}
