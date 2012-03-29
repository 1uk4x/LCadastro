using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCadastro.Logic.Entity
{
    class Cliente : Entity
    {
       
        public String Nome { get; set;}
        public String Cpf { get; set; }
        public String Rg { get; set; }
        public String Endereco { get; set; }
        public String Tel { get; set; }
        public String Cel { get; set; }

        public int _NcomprasEfetuadas { get; set; }
        public Double _TotalGastoComCompras { get; set; }

        public Cliente(int ID, String _nome, String _cpf, String _rg, String _endereco, String _tel)
            :base (ID)
        {
            Nome = _nome;
            Cpf = _cpf;
            Rg = _rg;
            Endereco = _endereco;
            Tel = _tel;
        }
  
    }
}
