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
        /*
       bool IAuthed = false;
       public bool Passed()
        {
            return IAuthed;
        }
        */
        Cliente registro;
        ClienteDAO clientes;
        public MainWindow()
        {
            InitializeComponent();
            //var login = new Login();

            // login.ShowDialog();
            //Quando a janela fexar essa vai abrir e a primeira coisa que vai acontecer vai ser a verficação abaixo:

            /*
            if (!login.Passed())
            {
                MessageBox.Show("Senha Errada! Tente Novamente");
                this.Close();
            }
            login.Close();
            */

         //   registro = new Cliente();
          //  clientes = new ClienteDAO();

            //DEFAULT NAVEGACAO
           // frame1.Navigate(new CadastroDeContatos());
        }

        public MainWindow(Cadastro.IPagina pagina)
        {
            InitializeComponent();
           // Cadastro.IPagina title = (Cadastro.IPagina)o;
            this.Title = pagina.Title;
            this.frame1.Navigate(pagina);
            this.ShowDialog();
            
        }

        public void ShowDialog(object o)
        {
            this.frame1.Navigate(o);
            this.ShowDialog();
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

    }
}