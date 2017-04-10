using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logintest;

namespace WindowsFormsApplication2
{
    public partial class Examination : Form
    {
        public int id;
        public Examination(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int appid = 0;
            linkDataContext db = new linkDataContext();
            var q = from a in db.Appointments where a.Patient_id == this.id select a.App_id;
            foreach (var item in q)
            {
                appid = item;                
            }

            App_data apdt = new App_data();
            apdt.App_id = appid;
            apdt.P_id = this.id;
            apdt.Examination_data = richTextBox1.Text;

            db.App_datas.InsertOnSubmit(apdt);
            db.App_datas.Context.SubmitChanges();

            MessageBox.Show("Data Inserted");


        }
    }
}
