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
    public partial class Rectangle : Form
    {
        
        public Rectangle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RectLogic rectLogic = new RectLogic();
            rectLogic.setWidth(int.Parse(widthtxt.Text));
            rectLogic.setHeight(int.Parse(heighttxt.Text));
            RectArea.Text = rectLogic.Area().ToString();
            RectPeri.Text = rectLogic.Perimeter().ToString();
        }
    }
}
