using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDBasic
{
    public partial class StringHandling : Form
    {
        public StringHandling()
        {
            InitializeComponent();
        }

        private void Exe_Click(object sender, EventArgs e)
        {
            string raw = inputTxt.Text;
            raw.Trim();
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            raw = regex.Replace(raw, " ");
            raw = raw.ToLower();
            OutputTxt.Text = raw;
        }
    }
}
