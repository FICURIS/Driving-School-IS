namespace WindowsFormsApp
{
    partial class GroupForm
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
            this.panelCenter = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.textBoxPoisk = new System.Windows.Forms.TextBox();
            this.labelPoisk = new System.Windows.Forms.Label();
            this.btnPoisk = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drivingSchoolDataBaseDataSet1 = new WindowsFormsApp.DrivingSchoolDataBaseDataSet1();
            this.studentsTableAdapter = new WindowsFormsApp.DrivingSchoolDataBaseDataSet1TableAdapters.StudentsTableAdapter();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drivingSchoolDataBaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.dataGridView1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCenter.Location = new System.Drawing.Point(0, 60);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1182, 408);
            this.panelCenter.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 408);
            this.dataGridView1.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.textBoxPoisk);
            this.panelTop.Controls.Add(this.labelPoisk);
            this.panelTop.Controls.Add(this.btnPoisk);
            this.panelTop.Controls.Add(this.button4);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1182, 60);
            this.panelTop.TabIndex = 10;
            // 
            // textBoxPoisk
            // 
            this.textBoxPoisk.Location = new System.Drawing.Point(88, 18);
            this.textBoxPoisk.Name = "textBoxPoisk";
            this.textBoxPoisk.Size = new System.Drawing.Size(292, 22);
            this.textBoxPoisk.TabIndex = 7;
            // 
            // labelPoisk
            // 
            this.labelPoisk.AutoSize = true;
            this.labelPoisk.Location = new System.Drawing.Point(21, 21);
            this.labelPoisk.Name = "labelPoisk";
            this.labelPoisk.Size = new System.Drawing.Size(47, 16);
            this.labelPoisk.TabIndex = 6;
            this.labelPoisk.Text = "Поиск";
            // 
            // btnPoisk
            // 
            this.btnPoisk.Location = new System.Drawing.Point(400, 12);
            this.btnPoisk.Name = "btnPoisk";
            this.btnPoisk.Size = new System.Drawing.Size(100, 35);
            this.btnPoisk.TabIndex = 5;
            this.btnPoisk.Text = "Найти";
            this.btnPoisk.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(517, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 497);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.drivingSchoolDataBaseDataSet1;
            // 
            // drivingSchoolDataBaseDataSet1
            // 
            this.drivingSchoolDataBaseDataSet1.DataSetName = "DrivingSchoolDataBaseDataSet1";
            this.drivingSchoolDataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 541);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drivingSchoolDataBaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox textBoxPoisk;
        private System.Windows.Forms.Label labelPoisk;
        private System.Windows.Forms.Button btnPoisk;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private DrivingSchoolDataBaseDataSet1 drivingSchoolDataBaseDataSet1;
        private DrivingSchoolDataBaseDataSet1TableAdapters.StudentsTableAdapter studentsTableAdapter;
    }
}