using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCadastro.Logic.Entity
{
    class Roupa : Entity
    {
      
        private Double _preco;
        

        private String _nome;
        private String _cor;
        private String _tipo;
        private String _modelo;

        public Roupa(int ID, int codigo, Double preco, String nome, String cor, String tipo, String modelo)
            :base (ID)
        {
            _preco = preco;
            _nome = nome;
            _cor = cor;
            _tipo = tipo;
            _modelo = modelo;
            
        }

        public Double Preco { get { return _preco; } set { _preco = value; } }
        public String Nome { get { return _nome; } set { _nome = value; } }
        public String Cor { get { return _cor; } set { _cor = value; } }
        public String Tipo { get { return _tipo; } set { _tipo = value; } }
        public String Modelo { get { return _modelo; } set { _modelo = value; } }
    }
}
