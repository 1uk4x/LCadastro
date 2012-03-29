using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    interface IAcessoDB<T>
    {
        int SaveRegistro(T registro);
        bool UpdateRegistro(T registro);
        List<T> GetRegistro(T registro);
        List<T> GetAll();
        T GetRegistroPorCodigo(int codigo);
        bool DeleteRegistro(T registro);
    }
}
