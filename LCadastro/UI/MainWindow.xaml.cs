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
using DAL;
using DAL.Logic.DAO;
using System.Data.Entity;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window//, IAuth
    {
       bool IAuthed = false;
       public bool Passed()
        {
            return IAuthed;
        }

       Cliente registro;
       ClienteDAO clientes;
        public MainWindow()
        {
            InitializeComponent();
            var login = new Login();
            
            // login.ShowDialog();
            //Quando a janela fexar essa vai abrir e a primeira coisa que vai acontecer vai ser a verficação abaixo:


            if (!login.Passed())
            {
                MessageBox.Show("Senha Errada! Tente Novamente");
                this.Close();
            }
            login.Close();


            registro = new Cliente();
            clientes = new ClienteDAO();
            Listagem.Lista lista = new Listagem.Lista();
            frame_Lista.Navigate(lista);
            lista.dataGrid1.ItemsSource = clientes.GetRegistro(registro);
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            
        }

        private void MenuItem_Cliente(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new CadastroDeContatos());
        }

        private void MenuItem_Funcionario(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new CadastroDeFuncionarios1());
        }

        private void MenuItem_Bar(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new CadastroDeBar());
        }

        public void MenuItem_Roupa(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new CadastroDeRoupas());
        }

        private void searchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            textBoxSearch.Text = "";
        }

        private void searchBox_LostFocus(object sender, RoutedEventArgs e)
        {
            textBoxSearch.Text = "Procurar...";
        }

        /*
       public void Tab_Roupa()
        {
          
            switch (tabItem_CRoupa.Visibility)
            {
                case System.Windows.Visibility.Collapsed:
                    tabItem_CRoupa.Visibility = System.Windows.Visibility.Visible;
                    break;
                case System.Windows.Visibility.Visible:
                    tabItem_CRoupa.Visibility = System.Windows.Visibility.Collapsed;
                    break;
            }
        }
       public void Tab_Bar()
       {
           switch (tabItem_CBar.Visibility)
           {
               case System.Windows.Visibility.Collapsed:
                   tabItem_CBar.Visibility = System.Windows.Visibility.Visible;
                   break;
               case System.Windows.Visibility.Visible:
                   tabItem_CBar.Visibility = System.Windows.Visibility.Collapsed;
                   break;
           }
       }
       public void Tab_Funcionario()
       {
           switch (tabItem_CClientes.Visibility)
           {
               case System.Windows.Visibility.Collapsed:
                   tabItem_CFuncionarios.Visibility = System.Windows.Visibility.Visible;
                   break;
               case System.Windows.Visibility.Visible:
                   tabItem_CFuncionarios.Visibility = System.Windows.Visibility.Collapsed;
                   break;
           }
       }
       public void Tab_Cliente()
       {
           switch (tabItem_CClientes.Visibility)
           {
               case System.Windows.Visibility.Collapsed:
                   tabItem_CClientes.Visibility = System.Windows.Visibility.Visible;
                   break;
               case System.Windows.Visibility.Visible:
                   tabItem_CClientes.Visibility = System.Windows.Visibility.Collapsed;
                   break;
           }
       }
         */
    }
}
