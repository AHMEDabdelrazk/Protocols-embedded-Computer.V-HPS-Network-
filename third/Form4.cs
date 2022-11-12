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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4.ActiveForm.Hide();
            Form1 F1 = new Form1();
            F1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4.ActiveForm.Close();
        }
    }
}
