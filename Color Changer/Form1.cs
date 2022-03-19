using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Changer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void color_change_1_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(45, 22, 157);
            MessageBox.Show("The form is now Purple");
        }

        private void color_change_2_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(13, 189, 72);
            MessageBox.Show("The form is now Lime Green");
        }
        private void reset_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }


    }
}
