using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CRUDBasic
{
    public partial class FileExplorer : Form
    {
        public FileExplorer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = link.Text;
            if (Directory.Exists(url))
            {
                string[] str = Directory.GetFiles(url);
                if(str.Length > 0)
                {
                    foreach (string i in str)
                    {
                        box.Text += i + "\n";
                    }
                }
                else MessageBox.Show("Can not find any file");
            }
            else MessageBox.Show("Can not find any file");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            link.Text = "";
            box.Text = "";
        }
    }
}
