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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }
    }
}
