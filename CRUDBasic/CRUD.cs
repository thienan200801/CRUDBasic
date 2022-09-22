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
            DisplayListViewItem();
        }

        private void DisplayListViewItem()
        {
            if(sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text; 
            sqlCmd.CommandText = "select * from VATTU";
            
            sqlCmd.Connection = sqlCon; //send query to connect

            SqlDataReader reader = sqlCmd.ExecuteReader();
            danhSachVT.Items.Clear();

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

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (sqlCon != null) sqlCon = new SqlConnection(strCon);
            if(sqlCon.State == ConnectionState.Closed) sqlCon.Open();

            //Get data from textbox
            string newMaVT = maVT.Text.Trim();
            string newTenVT = tenVT.Text.Trim();
            string newDVT = donViTinh.Text.Trim();
            string newPhanTram = phanTram.Text.Trim();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "insert into VATTU values ('" + newMaVT + "', '" + newTenVT + "', '" + newDVT + "', '" + newPhanTram + "')";

            sqlCmd.Connection = sqlCon;
            int result = sqlCmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Added");
                DisplayListViewItem();
            }
            else MessageBox.Show("Failed to add");
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(sqlCon != null) sqlCon = new SqlConnection(strCon);
            if(sqlCon.State == ConnectionState.Closed) sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update VATTU set MAVT = '"+maVT.Text+"', TENVT = '"+tenVT.Text+"', DONVITINH = '"+donViTinh.Text+"', PHANTRAM = '"+phanTram.Text+"' where MAVT = '"+maVT.Text+"'";
            //cmd.CommandText = "update VATTU set MAVT = @maVT, TENVT = @tenVT, DONVITINH = @dvt, PHANTRAM = @phantram where MAVT = @maVT";

            //SqlParameter parMaVT = new SqlParameter("@maVT", SqlDbType.VarChar);
            //SqlParameter parTenVT = new SqlParameter("@tenVT", SqlDbType.VarChar);
            //SqlParameter parDonViTinh = new SqlParameter("@dvt", SqlDbType.VarChar);
            //SqlParameter parPhanTram = new SqlParameter("@phantram", SqlDbType.Real);

            //parMaVT.Value = maVT.Text.Trim();
            //parTenVT.Value = tenVT.Text.Trim();
            //parDonViTinh.Value = donViTinh.Text.Trim();
            //parPhanTram.Value = phanTram.Text.Trim();

            //cmd.Parameters.Add(parMaVT);
            //cmd.Parameters.Add(parTenVT);
            //cmd.Parameters.Add(parDonViTinh);
            //cmd.Parameters.Add(parPhanTram);

            cmd.Connection = sqlCon;

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Updated");
                DisplayListViewItem();
            }
            else MessageBox.Show("Failed to update");
        }

        private void danhSachVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (danhSachVT.SelectedItems.Count == 0) return;

            ListViewItem lvi = danhSachVT.SelectedItems[0];

            maVT.Text = lvi.SubItems[0].Text;
            tenVT.Text = lvi.SubItems[1].Text;
            donViTinh.Text = lvi.SubItems[2].Text;
            phanTram.Text = lvi.SubItems[3].Text;


        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
