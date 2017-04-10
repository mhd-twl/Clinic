namespace Logintest
{
    partial class ActionTracer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medical_CenterDataSet = new Logintest.Medical_CenterDataSet();
            this.actionRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actionRecordTableAdapter = new Logintest.Medical_CenterDataSetTableAdapters.ActionRecordTableAdapter();
            this.actionRecordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicalCenterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actionRecordBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.actionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_CenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionRecordBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalCenterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionRecordBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(192, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recent Action  Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(25, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 185);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actionidDataGridViewTextBoxColumn,
            this.empidDataGridViewTextBoxColumn,
            this.patientidDataGridViewTextBoxColumn,
            this.actiondateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.actionRecordBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 185);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // medical_CenterDataSet
            // 
            this.medical_CenterDataSet.DataSetName = "Medical_CenterDataSet";
            this.medical_CenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actionRecordBindingSource
            // 
            this.actionRecordBindingSource.DataMember = "ActionRecord";
            this.actionRecordBindingSource.DataSource = this.medical_CenterDataSet;
            // 
            // actionRecordTableAdapter
            // 
            this.actionRecordTableAdapter.ClearBeforeFill = true;
            // 
            // actionRecordBindingSource1
            // 
            this.actionRecordBindingSource1.DataMember = "ActionRecord";
            this.actionRecordBindingSource1.DataSource = this.medical_CenterDataSet;
            // 
            // medicalCenterDataSetBindingSource
            // 
            this.medicalCenterDataSetBindingSource.DataSource = this.medical_CenterDataSet;
            this.medicalCenterDataSetBindingSource.Position = 0;
            // 
            // actionRecordBindingSource2
            // 
            this.actionRecordBindingSource2.DataMember = "ActionRecord";
            this.actionRecordBindingSource2.DataSource = this.medicalCenterDataSetBindingSource;
            // 
            // actionidDataGridViewTextBoxColumn
            // 
            this.actionidDataGridViewTextBoxColumn.DataPropertyName = "Action_id";
            this.actionidDataGridViewTextBoxColumn.HeaderText = "Action_id";
            this.actionidDataGridViewTextBoxColumn.Name = "actionidDataGridViewTextBoxColumn";
            this.actionidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "Emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "Emp_id";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            // 
            // patientidDataGridViewTextBoxColumn
            // 
            this.patientidDataGridViewTextBoxColumn.DataPropertyName = "Patient_id";
            this.patientidDataGridViewTextBoxColumn.HeaderText = "Patient_id";
            this.patientidDataGridViewTextBoxColumn.Name = "patientidDataGridViewTextBoxColumn";
            // 
            // actiondateDataGridViewTextBoxColumn
            // 
            this.actiondateDataGridViewTextBoxColumn.DataPropertyName = "Action_date";
            this.actiondateDataGridViewTextBoxColumn.HeaderText = "Action_date";
            this.actiondateDataGridViewTextBoxColumn.Name = "actiondateDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // ActionTracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ActionTracer";
            this.Text = "ActionTracer";
            this.Load += new System.EventHandler(this.ActionTracer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_CenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionRecordBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalCenterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionRecordBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Medical_CenterDataSet medical_CenterDataSet;
        private System.Windows.Forms.BindingSource actionRecordBindingSource;
        private Medical_CenterDataSetTableAdapters.ActionRecordTableAdapter actionRecordTableAdapter;
        private System.Windows.Forms.BindingSource medicalCenterDataSetBindingSource;
        private System.Windows.Forms.BindingSource actionRecordBindingSource1;
        private System.Windows.Forms.BindingSource actionRecordBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
    }
}