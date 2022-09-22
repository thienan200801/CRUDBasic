using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=LAPTOP-LJCG1CT5\SQLEXPRESS;Initial Catalog=DEMO;Integrated Security=True";
        SqlConnection sqlConnection = null;
        private void Open_Click(object sender, EventArgs e)
        {
            try
            {
                if(sqlConnection == null)
                    sqlConnection = new SqlConnection(connectionString);
                if(sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                    MessageBox.Show("Opened");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (sqlConnection.State == ConnectionState.Open && sqlConnection != null)
            {
                sqlConnection.Close();
                MessageBox.Show("Closed");
            }
            else MessageBox.Show("Please connect");
        }

        private void Problem1_Click(object sender, EventArgs e)
        {
            P1Dashboard p1 = new P1Dashboard();
            p1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileExplorer f = new FileExplorer();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringHandling stringHandling = new StringHandling();
            stringHandling.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            crud.ShowDialog();
        }
    }
}
