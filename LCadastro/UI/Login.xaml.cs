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

namespace UI
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window//, IAuth
    {
        static bool GLOBAL = false;
        bool IAuthed = false;
        public bool Passed()
        {
            new Login().ShowDialog();
            return GLOBAL;
        }
  

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            GLOBAL = true;
            this.Close();
        }

        private void GotFocus(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "Senha")
            textBox1.Text = "";
        }

        private void LostFocus(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text == "")
            textBox1.Text = "Senha";
        }

        private void LostFocus1(object sender, RoutedEventArgs e)
        {
            if(comboBox1.Text == "")
            comboBox1.Text = "Funcionario";
        }
    }
}
