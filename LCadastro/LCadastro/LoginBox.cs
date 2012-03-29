using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LCadastro
{
    public partial class LoginBox : Form
    {
        public LoginBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ds1 = new DataSet();
            con.Open();
           // SqlCommand
                
                new MainWindow().Show();
            
            
        }

        SqlConnection con;
        DataSet ds1;

        private void LoginBox_Load(object sender, EventArgs e)
        {
            this.funcionarioTableAdapter.Fill(this.lCadastroDBDataSet.Funcionario);
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = "";
        }

    }

}