namespace Logintest
{
    partial class PatientProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.resultdatatext = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.P_fullnametext = new System.Windows.Forms.Label();
            this.P_phonenumtext = new System.Windows.Forms.Label();
            this.P_balancetext = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ExaminationPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.P_balance = new System.Windows.Forms.Label();
            this.P_phonenum = new System.Windows.Forms.Label();
            this.P_fullname = new System.Windows.Forms.Label();
            this.ResultPanel.SuspendLayout();
            this.ExaminationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Save Result";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ResultPanel
            // 
            this.ResultPanel.BackColor = System.Drawing.Color.White;
            this.ResultPanel.Controls.Add(this.resultdatatext);
            this.ResultPanel.Location = new System.Drawing.Point(19, 373);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(653, 95);
            this.ResultPanel.TabIndex = 27;
            // 
            // resultdatatext
            // 
            this.resultdatatext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultdatatext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultdatatext.Enabled = false;
            this.resultdatatext.Location = new System.Drawing.Point(0, 0);
            this.resultdatatext.Name = "resultdatatext";
            this.resultdatatext.Size = new System.Drawing.Size(653, 95);
            this.resultdatatext.TabIndex = 0;
            this.resultdatatext.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add Result";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // P_fullnametext
            // 
            this.P_fullnametext.AutoSize = true;
            this.P_fullnametext.Location = new System.Drawing.Point(211, 39);
            this.P_fullnametext.Name = "P_fullnametext";
            this.P_fullnametext.Size = new System.Drawing.Size(41, 13);
            this.P_fullnametext.TabIndex = 25;
            this.P_fullnametext.Text = "label10";
            // 
            // P_phonenumtext
            // 
            this.P_phonenumtext.AutoSize = true;
            this.P_phonenumtext.Location = new System.Drawing.Point(211, 75);
            this.P_phonenumtext.Name = "P_phonenumtext";
            this.P_phonenumtext.Size = new System.Drawing.Size(35, 13);
            this.P_phonenumtext.TabIndex = 24;
            this.P_phonenumtext.Text = "label9";
            // 
            // P_balancetext
            // 
            this.P_balancetext.AutoSize = true;
            this.P_balancetext.Location = new System.Drawing.Point(211, 110);
            this.P_balancetext.Name = "P_balancetext";
            this.P_balancetext.Size = new System.Drawing.Size(35, 13);
            this.P_balancetext.TabIndex = 23;
            this.P_balancetext.Text = "label8";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(653, 119);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(653, 119);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // ExaminationPanel
            // 
            this.ExaminationPanel.BackColor = System.Drawing.Color.White;
            this.ExaminationPanel.Controls.Add(this.richTextBox2);
            this.ExaminationPanel.Controls.Add(this.richTextBox1);
            this.ExaminationPanel.Location = new System.Drawing.Point(19, 215);
            this.ExaminationPanel.Name = "ExaminationPanel";
            this.ExaminationPanel.Size = new System.Drawing.Size(653, 119);
            this.ExaminationPanel.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Current Examination Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(547, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 125);
            this.panel1.TabIndex = 19;
            // 
            // P_balance
            // 
            this.P_balance.AutoSize = true;
            this.P_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.P_balance.Location = new System.Drawing.Point(19, 106);
            this.P_balance.Name = "P_balance";
            this.P_balance.Size = new System.Drawing.Size(105, 17);
            this.P_balance.TabIndex = 18;
            this.P_balance.Text = "Money Balance";
            // 
            // P_phonenum
            // 
            this.P_phonenum.AutoSize = true;
            this.P_phonenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.P_phonenum.Location = new System.Drawing.Point(19, 71);
            this.P_phonenum.Name = "P_phonenum";
            this.P_phonenum.Size = new System.Drawing.Size(103, 17);
            this.P_phonenum.TabIndex = 16;
            this.P_phonenum.Text = "Phone Number";
            // 
            // P_fullname
            // 
            this.P_fullname.AutoSize = true;
            this.P_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.P_fullname.Location = new System.Drawing.Point(19, 37);
            this.P_fullname.Name = "P_fullname";
            this.P_fullname.Size = new System.Drawing.Size(71, 17);
            this.P_fullname.TabIndex = 15;
            this.P_fullname.Text = "Full Name";
            // 
            // PatientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 516);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.P_fullnametext);
            this.Controls.Add(this.P_phonenumtext);
            this.Controls.Add(this.P_balancetext);
            this.Controls.Add(this.ExaminationPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.P_balance);
            this.Controls.Add(this.P_phonenum);
            this.Controls.Add(this.P_fullname);
            this.Name = "PatientProfile";
            this.Text = "PatientProfile";
            this.Load += new System.EventHandler(this.PatientProfile_Load);
            this.ResultPanel.ResumeLayout(false);
            this.ExaminationPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel ResultPanel;
        private System.Windows.Forms.RichTextBox resultdatatext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label P_fullnametext;
        private System.Windows.Forms.Label P_phonenumtext;
        private System.Windows.Forms.Label P_balancetext;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel ExaminationPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label P_balance;
        private System.Windows.Forms.Label P_phonenum;
        private System.Windows.Forms.Label P_fullname;
    }
}