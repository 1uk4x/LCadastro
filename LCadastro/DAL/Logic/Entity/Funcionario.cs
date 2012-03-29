using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCadastro.Logic.Entity
{
    class Funcionario : Entity
    {
        private String _usuario;
        private String _senha;
        private String _nome;

        private Double _Tvendido;
        private Double _Pvendido;

        public Funcionario(int ID, String usuario, String senha, String nome, Double Tventido, Double Pvendido)
            : base(ID)
        {
            _usuario = usuario;
            _senha = senha;
            _nome = nome;
            _Tvendido = Tventido;
            _Pvendido = Pvendido;
        }

        public String Usuario { get { return _usuario; } set { _usuario = value; } }
        public String Senha { get { return _senha; } set { _senha = value; } }
        public String Nome { get { return _nome; } set { _nome = value; } }
        public Double TotalVendido { get { return _Tvendido; } set { _Tvendido = value; } }
        

    }
}
