using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsuTrainer
{

    public partial class Form1 : Form
    {
        Formoverlay frm = new Formoverlay();
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                frm.Show();
            }
            else
            {
                frm.Hide();
            }
        }
    }
}
