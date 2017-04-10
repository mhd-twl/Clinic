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
    public partial class Doctor_profile : Form
    {
        Employee emp = new Employee();
        public Doctor_profile( Employee w)
        {
            emp = w;
            InitializeComponent();
            
        }

        private void Employee_Profile_Load(object sender, EventArgs e)
        {
            this.Doc_namelbl.Text = emp.Emp_FirstName;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
