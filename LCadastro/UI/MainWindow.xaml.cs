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
using System.Windows.Shapes;
using UI.Listagem;
using DAL.Logic.DAO;
using DAL;

namespace UI
{
    /// <summary>
    /// Interaction logic for JanelaPrincipal.xaml
    /// </summary>
    public partial class JanelaPrincipal : Window
    {
        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        private void Button_Cadastrar_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().ShowDialog();
        }

        private void buttonListar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.ShowDialog(new Lista(new ClienteDAO().GetAll()));
           
            
        }





        ///@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        ///

        private void MenuItem_Cliente(object sender, RoutedEventArgs e)
        {
          new MainWindow(new CadastroDeContatos());
        }

        private void MenuItem_Funcionario(object sender, RoutedEventArgs e)
        {
           new MainWindow(new CadastroDeFuncionarios1());
        }

        private void MenuItem_Bar(object sender, RoutedEventArgs e)
        {
            new MainWindow(new CadastroDeBar());

        }

        public void MenuItem_Roupa(object sender, RoutedEventArgs e)
        {
           new MainWindow(new CadastroDeRoupas());
        }

    }
}
