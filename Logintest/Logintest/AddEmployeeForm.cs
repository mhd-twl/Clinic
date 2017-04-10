using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logintest
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            string s1, s2, s3, s4, s5, s6, s7, s8;
            s1 = textBox1.Text.Trim();
            s2 = textBox2.Text.Trim();
            s3 = textBox3.Text.Trim();
            s4= textBox4.Text.Trim();
            s5 = textBox5.Text.Trim();
            s6 = Daytextbox.Text.Trim();
            s7 = textBox7.Text.Trim();
            s8 = textBox8.Text.Trim();

        }
    }
}
