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
    /// Interaction logic for Lista2.xaml
    /// </summary>
    public partial class Lista2 : UserControl
    {
        public Lista2()
        {
            InitializeComponent();
            this.dataGrid1.ItemsSource = new DAL.Logic.DAO.ClienteDAO().GetAll();
        }
    }
}
