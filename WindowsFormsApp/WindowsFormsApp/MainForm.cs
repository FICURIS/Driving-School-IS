using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm(string login, int roleId)
        {
            InitializeComponent();

            labelUser.Text = "Пользователь: " + login;

            if (roleId == 1)
            {
                labelRole.Text =
                    "Роль: Администратор";
            }

            if (roleId == 2)
            {
                labelRole.Text =
                    "Роль: Преподаватель";
            }

            if (roleId == 3)
            {
                labelRole.Text =
                    "Роль: Инструктор";
            }
        }

        private void OpenChildForm( Form childForm)
        {
            contentPanel.Controls.Clear();
            childForm.TopLevel = false;

            childForm.FormBorderStyle = FormBorderStyle.None;

            childForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTeoryLessons_Click(object sender, EventArgs e)
        {

        }

        private void labelRole_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();

            frm.Show();
            this.Hide();
        }

        private void btnStudents_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new StudentsForm());
        }

        private void btnInstructors_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new InstructorsForm());
        }

        private void btnGroups_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new GroupForm());
        }

        private void btnCars_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new CarsForm());
        }

        private void btnTeoryLessons_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPracticeLessons_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new PracticeLessonsForm());
        }

        private void btnExams_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ExamsForm());
        }
    }
}
