namespace WindowsFormsApp
{
    partial class MainForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPracticeLessons = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnTeoryLessons = new System.Windows.Forms.Button();
            this.btnCars = new System.Windows.Forms.Button();
            this.btnGroups = new System.Windows.Forms.Button();
            this.btnInstructors = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.labelTittle = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.btnLogout);
            this.topPanel.Controls.Add(this.labelRole);
            this.topPanel.Controls.Add(this.labelUser);
            this.topPanel.Controls.Add(this.labelTittle);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1182, 60);
            this.topPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPracticeLessons);
            this.panel1.Controls.Add(this.btnExams);
            this.panel1.Controls.Add(this.btnTeoryLessons);
            this.panel1.Controls.Add(this.btnCars);
            this.panel1.Controls.Add(this.btnGroups);
            this.panel1.Controls.Add(this.btnInstructors);
            this.panel1.Controls.Add(this.btnStudents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 593);
            this.panel1.TabIndex = 2;
            // 
            // btnPracticeLessons
            // 
            this.btnPracticeLessons.Location = new System.Drawing.Point(31, 317);
            this.btnPracticeLessons.Name = "btnPracticeLessons";
            this.btnPracticeLessons.Size = new System.Drawing.Size(130, 55);
            this.btnPracticeLessons.TabIndex = 6;
            this.btnPracticeLessons.Text = "Практические занятия";
            this.btnPracticeLessons.UseVisualStyleBackColor = true;
            this.btnPracticeLessons.Click += new System.EventHandler(this.btnPracticeLessons_Click_1);
            // 
            // btnExams
            // 
            this.btnExams.Location = new System.Drawing.Point(31, 378);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(130, 55);
            this.btnExams.TabIndex = 5;
            this.btnExams.Text = "Экзамены";
            this.btnExams.UseVisualStyleBackColor = true;
            this.btnExams.Click += new System.EventHandler(this.btnExams_Click_1);
            // 
            // btnTeoryLessons
            // 
            this.btnTeoryLessons.Location = new System.Drawing.Point(31, 256);
            this.btnTeoryLessons.Name = "btnTeoryLessons";
            this.btnTeoryLessons.Size = new System.Drawing.Size(130, 55);
            this.btnTeoryLessons.TabIndex = 4;
            this.btnTeoryLessons.Text = "Теоритические занятия";
            this.btnTeoryLessons.UseVisualStyleBackColor = true;
            this.btnTeoryLessons.Click += new System.EventHandler(this.btnTeoryLessons_Click_1);
            // 
            // btnCars
            // 
            this.btnCars.Location = new System.Drawing.Point(31, 195);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(130, 55);
            this.btnCars.TabIndex = 3;
            this.btnCars.Text = "Автомобили";
            this.btnCars.UseVisualStyleBackColor = true;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click_1);
            // 
            // btnGroups
            // 
            this.btnGroups.Location = new System.Drawing.Point(31, 134);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(130, 55);
            this.btnGroups.TabIndex = 2;
            this.btnGroups.Text = "Группы";
            this.btnGroups.UseVisualStyleBackColor = true;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click_1);
            // 
            // btnInstructors
            // 
            this.btnInstructors.Location = new System.Drawing.Point(31, 73);
            this.btnInstructors.Name = "btnInstructors";
            this.btnInstructors.Size = new System.Drawing.Size(130, 55);
            this.btnInstructors.TabIndex = 1;
            this.btnInstructors.Text = "Инструкторы";
            this.btnInstructors.UseVisualStyleBackColor = true;
            this.btnInstructors.Click += new System.EventHandler(this.btnInstructors_Click_1);
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(31, 12);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(130, 55);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Курсанты";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click_1);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(200, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(982, 593);
            this.contentPanel.TabIndex = 3;
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Location = new System.Drawing.Point(20, 18);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(266, 16);
            this.labelTittle.TabIndex = 0;
            this.labelTittle.Text = "Информационная система \"Автошкола\"";
            // 
            // labelUser
            // 
            this.labelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(327, 18);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(105, 16);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Пользователь:";
            // 
            // labelRole
            // 
            this.labelRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(536, 18);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(42, 16);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Роль:";
            this.labelRole.Click += new System.EventHandler(this.labelRole_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(1070, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 35);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Выход";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPracticeLessons;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnTeoryLessons;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Button btnGroups;
        private System.Windows.Forms.Button btnInstructors;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Button btnLogout;
    }
}