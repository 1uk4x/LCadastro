using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using DAL;
using DAL.Logic.DAO;
using System.Data.Entity;

namespace UI
{
    /// <summary>
    /// Interaction logic for CadastroDeContatos.xaml
    /// </summary>
    public partial class CadastroDeContatos : Page
    {

        Cliente registro;
        ClienteDAO clientes;

        public CadastroDeContatos()
        {
            InitializeComponent();

            clientes = new ClienteDAO();
            registro = new Cliente();


           
            
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            switch (this.Visibility)
            {
                case System.Windows.Visibility.Hidden:
                    this.Visibility = System.Windows.Visibility.Visible;
                    break;
                case System.Windows.Visibility.Visible:
                    this.Visibility = System.Windows.Visibility.Hidden;
                    break;
            }
        }
    }
}
