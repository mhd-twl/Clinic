using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace Logintest
{
    public partial class LogInForm : Form
    {

        public LogInForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String emp_name = Emp_nametextbox.Text.Trim();
            String emp_pass = Emp_passtextbox.Text.Trim();

            if (emp_name.Length <= 0 || emp_pass.Length <= 0)
            {
                MessageBox.Show("The Name Or The Password is Messing Make Sure You Enter It","Warrning",MessageBoxButtons.OK,MessageBoxIcon.Information);

                return;
            }
            linkDataContext link = new linkDataContext();

            var s = from d in link.Employees where d.Emp_FirstName.Trim() + " " + d.Emp_LastName.Trim() == emp_name && d.Password==emp_pass select d;
           
          //  MessageBox.Show("this employee   " + s.Count().ToString()+ "   is a doctor");
            int ee = Convert.ToInt32(s.First().Emp_id);
            
            var type1 = from w in link.Doctors where w.Emp_id ==ee select w;
            var type2 = from w in link.Nurses where w.Emp_id == ee select w;
            var type3 = from w in link.Secritaries where w.Emp_id == ee select w;
            if (type1.Count() > 0)
            {
                Doctor d = type1.First();

            //we have a docotr
                Doctor_profile doc = new Doctor_profile(s.First());
                doc.Show();
            
            }
            else if (type2.Count() > 0)
            {
                Nurse N = type2.First();
                //we have a Nurse
              Nurse_Profile n = new Nurse_Profile();
              n.Show();

            }
            else if (type3.Count() > 0)
            {
                Secritary N = type3.First();
                //we have a Secritary

            }
            else { 
            
            
            // incorrect password or emp doen'nt exist 
            
            }

            MessageBox.Show("this employee   "+type1.First().Extra_info+"   is a doctor");
            Doctor_profile f = new Doctor_profile(s.First());
            f.Show();
           // this.Close();


           

        }
    }
}
