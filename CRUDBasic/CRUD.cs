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
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }
        string strCon = @"Data Source=LAPTOP-LJCG1CT5\SQLEXPRESS;Initial Catalog=DEMO;Integrated Security=True";
        SqlConnection sqlCon = null;

        private void CRUD_Load(object sender, EventArgs e)
        {
            ListViewItem();
        }

        private void ListViewItem()
        {
            if(sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text; 
            sqlCmd.CommandText = "select * from VATTU";
            
            sqlCmd.Connection = sqlCon; //send query to connect

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string maVT = reader.GetString(0);
                string tenVT = reader.GetString(1);
                string dvTinh = reader.GetString(2);
                float phantram = reader.GetFloat(3);

                ListViewItem lvi = new ListViewItem(maVT);
                lvi.SubItems.Add(tenVT);
                lvi.SubItems.Add(dvTinh); 
                lvi.SubItems.Add(phantram.ToString());

                danhSachVT.Items.Add(lvi);
            }
            reader.Close();
        }

    }
}
