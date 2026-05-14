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
    public partial class GroupForm : Form
    {
        public GroupForm()
        {
            InitializeComponent();
        }

        private void LoadGroupData()
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query =
    "SELECT " +
    "Groups.GroupID, " +
    "Groups.GroupName, " +
    "Groups.StartDate, " +
    "Groups.EndDate, " +
    "Programs.ProgramID, " +
    "Programs.ProgramName, " +
    "Programs.TheoryHours, " +
    "Programs.PracticeHours, " +
    "Programs.Description, " +
    "Categories.CategoryID, " +
    "Categories.CategoryName " +
    "FROM Groups " +
    "INNER JOIN Programs " +
    "ON Groups.ProgramID = Programs.ProgramID " +
    "INNER JOIN Categories " +
    "ON Programs.CategoryID = Categories.CategoryID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();

                adapter.Fill(table);
                dataGridView1.DataSource = table;

                dataGridView1.Columns["GroupID"].Visible = false;

                dataGridView1.Columns["GroupName"].HeaderText =
                    "Название группы";

                dataGridView1.Columns["StartDate"].HeaderText =
                    "Дата начала";

                dataGridView1.Columns["EndDate"].HeaderText =
                    "Дата окончания";
                dataGridView1.Columns["ProgramID"].Visible = false;

                dataGridView1.Columns["ProgramName"].HeaderText =
                    "Название программы";

                dataGridView1.Columns["TheoryHours"].HeaderText =
                    "Часов теории";

                dataGridView1.Columns["PracticeHours"].HeaderText =
                    "Часов практики";

                dataGridView1.Columns["Description"].HeaderText =
                    "Описание";

                dataGridView1.Columns["CategoryID"].Visible = false;

                dataGridView1.Columns["CategoryName"].HeaderText =
                    "Категория";
            }
        }

        private void GroupDataForm_Load(object sender, EventArgs e)
        {
            LoadGroupData();
        }

        private void btnPoisk_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query =
            "SELECT " +
            "Groups.GroupID, " +
            "Groups.GroupName, " +
            "Groups.StartDate, " +
            "Groups.EndDate, " +
            "Programs.ProgramID, " +
            "Programs.ProgramName, " +
            "Programs.TheoryHours, " +
            "Programs.PracticeHours, " +
            "Programs.Description, " +
            "Categories.CategoryID, " +
            "Categories.CategoryName " +
            "FROM Groups " +
            "INNER JOIN Programs " +
            "ON Groups.ProgramID = Programs.ProgramID " +
            "INNER JOIN Categories " +
            "ON Programs.CategoryID = Categories.CategoryID " +
            "WHERE Groups.GroupName LIKE @search " +
            "OR Programs.ProgramName LIKE @search " +
            "OR Categories.CategoryName LIKE @search";


                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + textBoxPoisk.Text + "%");

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            LoadGroupData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ManageGroupsForm frm = new ManageGroupsForm();

            frm.ShowDialog();

            LoadGroupData();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите группу");
                return;
            }

            int groupId =
                Convert.ToInt32(
                    dataGridView1.SelectedRows[0].Cells["GroupID"].Value);

            ManageGroupsForm frm = new ManageGroupsForm(groupId);
            frm.ShowDialog();

            LoadGroupData();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите группу для удаления");
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту группу?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            int groupId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["GroupID"].Value);

            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query = "DELETE FROM Groups WHERE GroupID = @id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", groupId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Группа удалена");

            LoadGroupData();
        }
    }
}
