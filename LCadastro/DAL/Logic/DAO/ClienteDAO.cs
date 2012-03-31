using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL.Logic.DAO
{
    public class ClienteDAO : IAcessoDB<Cliente>
    {
        private LCadastroDBEntities cadastroEntities;

        public int SaveRegistro(Cliente registro)
        {
            using (cadastroEntities = new LCadastroDBEntities())
            {
                cadastroEntities.AddToClientes(registro);
                cadastroEntities.SaveChanges();
            }
            return registro.ID;
        }

        public bool UpdateRegistro(Cliente registro)
        {
            EntityKey key;
            object originalItem;

            using (cadastroEntities = new LCadastroDBEntities())
            {
                key = cadastroEntities.CreateEntityKey("Clientes", registro);

                if (cadastroEntities.TryGetObjectByKey(key, out originalItem))
                {
                    cadastroEntities.ApplyCurrentValues(key.EntitySetName, registro);
                }
                cadastroEntities.SaveChanges();
                return true;
            }
        }

        public List<Cliente> GetRegistro(Cliente registro)
        {
            cadastroEntities = new LCadastroDBEntities();

            IQueryable<Cliente> consultaCliente = cadastroEntities.Clientes.AsQueryable<Cliente>();

            if (registro.ID > 0)
            {
                consultaCliente = consultaCliente.Where(c => c.ID == registro.ID);
            }
            if (!string.IsNullOrEmpty(registro.email))
            {
                consultaCliente = consultaCliente.Where(c => c.cidade.Contains(registro.cidade));
            }
            if (!string.IsNullOrEmpty(registro.cidade))
            {
                consultaCliente = consultaCliente.Where(c => c.cidade.Contains(registro.cidade));
            }
            return consultaCliente.ToList();
        }

        public Cliente GetRegistroPorCodigo(int codigo)
        {
            cadastroEntities = new LCadastroDBEntities();
            Cliente cliente = cadastroEntities.Clientes.First(c => c.ID == codigo);
            return cliente;
        }

        public Cliente GetRegistroPorNome(String nome)
        {
            cadastroEntities = new LCadastroDBEntities();
            return ( from cliente in cadastroEntities.Clientes
                       
                   where cliente.nome.Equals(nome)
                       select cliente ).ToList();
        }

        public List<Cliente> GetAll()
        {
            cadastroEntities = new LCadastroDBEntities();
            IQueryable<Cliente> consultaCliente = cadastroEntities.Clientes.AsQueryable<Cliente>();
            return consultaCliente.ToList();
        }

        public bool DeleteRegistro(Cliente registro)
        {
            using (cadastroEntities = new LCadastroDBEntities())
            {
                var cli = cadastroEntities.Clientes.FirstOrDefault(c => c.ID == registro.ID);
                cadastroEntities.DeleteObject(cli);
                cadastroEntities.SaveChanges();
                return true;
            }
        }
    }
}
