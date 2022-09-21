using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDBasic
{
    public partial class P1Dashboard : Form
    {
        public P1Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Square square = new Square();
            square.ShowDialog();
        }
    }
}
