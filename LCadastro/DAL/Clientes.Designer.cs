﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace DAL
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class LCadastroDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new LCadastroDBEntities object using the connection string found in the 'LCadastroDBEntities' section of the application configuration file.
        /// </summary>
        public LCadastroDBEntities() : base("name=LCadastroDBEntities", "LCadastroDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LCadastroDBEntities object.
        /// </summary>
        public LCadastroDBEntities(string connectionString) : base(connectionString, "LCadastroDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LCadastroDBEntities object.
        /// </summary>
        public LCadastroDBEntities(EntityConnection connection) : base(connection, "LCadastroDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Cliente> Clientes
        {
            get
            {
                if ((_Clientes == null))
                {
                    _Clientes = base.CreateObjectSet<Cliente>("Clientes");
                }
                return _Clientes;
            }
        }
        private ObjectSet<Cliente> _Clientes;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Clientes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToClientes(Cliente cliente)
        {
            base.AddObject("Clientes", cliente);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LCadastroDBModel", Name="Cliente")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Cliente : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Cliente object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static Cliente CreateCliente(global::System.Int32 id)
        {
            Cliente cliente = new Cliente();
            cliente.ID = id;
            return cliente;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String nome
        {
            get
            {
                return _nome;
            }
            set
            {
                OnnomeChanging(value);
                ReportPropertyChanging("nome");
                _nome = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("nome");
                OnnomeChanged();
            }
        }
        private global::System.String _nome;
        partial void OnnomeChanging(global::System.String value);
        partial void OnnomeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String sobrenome
        {
            get
            {
                return _sobrenome;
            }
            set
            {
                OnsobrenomeChanging(value);
                ReportPropertyChanging("sobrenome");
                _sobrenome = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("sobrenome");
                OnsobrenomeChanged();
            }
        }
        private global::System.String _sobrenome;
        partial void OnsobrenomeChanging(global::System.String value);
        partial void OnsobrenomeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String endereco
        {
            get
            {
                return _endereco;
            }
            set
            {
                OnenderecoChanging(value);
                ReportPropertyChanging("endereco");
                _endereco = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("endereco");
                OnenderecoChanged();
            }
        }
        private global::System.String _endereco;
        partial void OnenderecoChanging(global::System.String value);
        partial void OnenderecoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String cep
        {
            get
            {
                return _cep;
            }
            set
            {
                OncepChanging(value);
                ReportPropertyChanging("cep");
                _cep = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("cep");
                OncepChanged();
            }
        }
        private global::System.String _cep;
        partial void OncepChanging(global::System.String value);
        partial void OncepChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String cidade
        {
            get
            {
                return _cidade;
            }
            set
            {
                OncidadeChanging(value);
                ReportPropertyChanging("cidade");
                _cidade = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("cidade");
                OncidadeChanged();
            }
        }
        private global::System.String _cidade;
        partial void OncidadeChanging(global::System.String value);
        partial void OncidadeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String email
        {
            get
            {
                return _email;
            }
            set
            {
                OnemailChanging(value);
                ReportPropertyChanging("email");
                _email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("email");
                OnemailChanged();
            }
        }
        private global::System.String _email;
        partial void OnemailChanging(global::System.String value);
        partial void OnemailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                OntelefoneChanging(value);
                ReportPropertyChanging("telefone");
                _telefone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("telefone");
                OntelefoneChanged();
            }
        }
        private global::System.String _telefone;
        partial void OntelefoneChanging(global::System.String value);
        partial void OntelefoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String celular
        {
            get
            {
                return _celular;
            }
            set
            {
                OncelularChanging(value);
                ReportPropertyChanging("celular");
                _celular = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("celular");
                OncelularChanged();
            }
        }
        private global::System.String _celular;
        partial void OncelularChanging(global::System.String value);
        partial void OncelularChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String contato
        {
            get
            {
                return _contato;
            }
            set
            {
                OncontatoChanging(value);
                ReportPropertyChanging("contato");
                _contato = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("contato");
                OncontatoChanged();
            }
        }
        private global::System.String _contato;
        partial void OncontatoChanging(global::System.String value);
        partial void OncontatoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String obs
        {
            get
            {
                return _obs;
            }
            set
            {
                OnobsChanging(value);
                ReportPropertyChanging("obs");
                _obs = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("obs");
                OnobsChanged();
            }
        }
        private global::System.String _obs;
        partial void OnobsChanging(global::System.String value);
        partial void OnobsChanged();

        #endregion
    
    }

    #endregion
    
}
