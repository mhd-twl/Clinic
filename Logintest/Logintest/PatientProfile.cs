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
    public partial class PatientProfile : Form
    {
        public Patient pa = new Patient();
        public PatientProfile(Patient p)
        {
            pa = p;
            InitializeComponent();
            
        }
        public double getbalance()
        {
            linkDataContext datacon = new linkDataContext();
            var o = from d in datacon.FincialRecords where d.P_id == pa.p_id select d.Balance;
            return Convert.ToDouble(o.First());

        }
        public String getexaminationdata() {

            
            linkDataContext datacon = new linkDataContext();
            var r = from g in datacon.App_datas select g.Examination_data;
            datacon.SubmitChanges();
            return r.Last();
        
        } 
        private void PatientProfile_Load(object sender, EventArgs e)
        {
            P_fullnametext.Text = pa.P_fname.Trim() + " " + pa.P_lname.Trim();
            P_phonenumtext.Text = pa.P_MobileNum.Trim();
            P_balancetext.Text = getbalance().ToString();
            richTextBox2.Text = getexaminationdata();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String r=resultdatatext.Text.Trim();
            linkDataContext datacon = new linkDataContext();
            var rr = from g in datacon.App_datas select g;
            datacon.App_datas.DeleteOnSubmit(rr.Last());
            rr.Last().Result_data = r;
            datacon.App_datas.InsertOnSubmit(rr.Last());
            datacon.SubmitChanges();

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
