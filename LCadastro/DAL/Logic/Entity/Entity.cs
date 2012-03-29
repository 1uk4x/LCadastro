using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCadastro.Logic.Entity
{
    abstract class Entity
    {
        public int ID { get; private set; }

        public Entity(int id)
        {
            ID = id;
        }
    }
}
