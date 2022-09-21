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
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            SquareLogic squareLogic = new SquareLogic(int.Parse(lengthtxt.Text));
            SquareArea.Text = squareLogic.Area().ToString();
            SquarePeri.Text = squareLogic.Perimeter().ToString();
        }
    }
}
