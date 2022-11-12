using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace third
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6.ActiveForm.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6.ActiveForm.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6.ActiveForm.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6.ActiveForm.Hide();
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }
    }
}
