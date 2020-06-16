using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Nascimento { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public bool admin { get; set; }
    }
}
