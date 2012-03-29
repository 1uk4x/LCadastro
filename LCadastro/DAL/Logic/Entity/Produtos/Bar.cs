using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCadastro.Logic.Entity.Produtos
{
    class Bar : Entity
    {
        public String Nome { get; set; }
        public Double Valor { get; set; }

        public Bar(int ID, String nome, Double valor)
            : base (ID)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
