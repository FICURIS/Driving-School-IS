using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void LoadStudents()
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query =
                    "SELECT " +
                    "Students.StudentID, " +
                    "Students.LastName, " +
                    "Students.FirstName, " +
                    "Students.MiddleName, " +
                    "Students.BirthDate, " +
                    "Students.PhoneNumber, " +
                    "Students.Email, " +
                    "Students.Address, " +
                    "Groups.GroupName " +
                    "FROM Students " +
                    "INNER JOIN Groups " +
                    "ON Students.GroupID = Groups.GroupID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();

                adapter.Fill(table);
                dataGridView1.DataSource = table;

                dataGridView1.Columns["StudentID"].Visible = false;

                dataGridView1.Columns["LastName"].HeaderText =
                    "Фамилия";

                dataGridView1.Columns["FirstName"].HeaderText =
                    "Имя";

                dataGridView1.Columns["MiddleName"].HeaderText =
                    "Отчество";

                dataGridView1.Columns["BirthDate"].HeaderText =
                    "Дата рождения";

                dataGridView1.Columns["PhoneNumber"].HeaderText =
                    "Телефон";

                dataGridView1.Columns["Email"].HeaderText =
                    "Email";

                dataGridView1.Columns["Address"].HeaderText =
                    "Адрес";

                dataGridView1.Columns["GroupName"].HeaderText =
                    "Группа";
            }
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnPoisk_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query = "SELECT * FROM Students" + " WHERE LastName LIKE @search" + " OR FirstName LIKE @search" + " OR MiddleName LIKE @search";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + textBoxPoisk.Text + "%");

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;

            }
        }

        private void textBoxPoisk_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageStudentsForm frm = new ManageStudentsForm();

            frm.ShowDialog();

            LoadStudents();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите курсанта для удаления");
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого курсанта?", "Подтверждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StudentID"].Value);

            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query = "DELETE FROM Students WHERE StudentID = @id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", studentId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Курсант удален");

            LoadStudents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выбери курсанта");
                return;
            }

            int studentId =
                Convert.ToInt32(
                    dataGridView1.SelectedRows[0].Cells["StudentID"].Value);

            ManageStudentsForm frm = new ManageStudentsForm(studentId);

            frm.ShowDialog();

            LoadStudents();
        }
    }
}
