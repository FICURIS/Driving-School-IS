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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentsForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drivingSchoolDataBaseDataSet1.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.drivingSchoolDataBaseDataSet1.Students);

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
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
