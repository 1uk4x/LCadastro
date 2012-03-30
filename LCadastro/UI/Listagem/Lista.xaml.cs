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

namespace UI.Listagem
{
    /// <summary>
    /// Interaction logic for Lista.xaml
    /// </summary>
    public partial class Lista : Page, Cadastro.IPagina
    {
        
        public Lista(List<DAL.Cliente> lista)
        {
            InitializeComponent();
            dataGrid1.ItemsSource = lista;
        }
        
    }
}
