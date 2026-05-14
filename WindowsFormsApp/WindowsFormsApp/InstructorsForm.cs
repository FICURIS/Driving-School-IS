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
    public partial class InstructorsForm : Form
    {
        public InstructorsForm()
        {
            InitializeComponent();
        }

        private void LoadInstructors()
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query =
                    "SELECT " +
                    "Instructors.InstructorID, " +
                    "Instructors.LastName, " +
                    "Instructors.FirstName, " +
                    "Instructors.MiddleName, " +
                    "Instructors.PhoneNumber " +
                    "FROM Instructors";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();

                adapter.Fill(table);
                dataGridView1.DataSource = table;

                dataGridView1.Columns["InstructorID"].Visible = false;

                dataGridView1.Columns["LastName"].HeaderText =
                    "Фамилия";

                dataGridView1.Columns["FirstName"].HeaderText =
                    "Имя";

                dataGridView1.Columns["MiddleName"].HeaderText =
                    "Отчество";

                dataGridView1.Columns["PhoneNumber"].HeaderText =
                    "Телефон";
            }
        }

        private void InstructorsForm_Load(object sender, EventArgs e)
        {
            LoadInstructors();
        }

        private void btnPoisk_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query = "SELECT " +
            "InstructorID, " +
            "LastName, " +
            "FirstName, " +
            "MiddleName, " +
            "PhoneNumber " +
            "FROM Instructors " +
            "WHERE LastName LIKE @search " +
            "OR FirstName LIKE @search " +
            "OR MiddleName LIKE @search";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + textBoxPoisk.Text + "%");

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadInstructors();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageInstructorsForm frm = new ManageInstructorsForm();

            frm.ShowDialog();

            LoadInstructors();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выбери инструктора");
                return;
            }

            int instructorId =
                Convert.ToInt32(
                    dataGridView1.SelectedRows[0].Cells["InstructorID"].Value);

            ManageInstructorsForm frm = new ManageInstructorsForm(instructorId);
            frm.ShowDialog();

            LoadInstructors();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите инструктора для удаления");
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого инструктора?", "Подтверждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            int instructorId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["InstructorID"].Value);

            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query = "DELETE FROM Instructors WHERE InstructorID = @id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", instructorId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Инструктор удален");

            LoadInstructors();
        }
    }
}
