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
    public partial class ManageGroupsForm : Form
    {
        public ManageGroupsForm()
        {
            InitializeComponent();

            LoadPrograms();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con =
       new SqlConnection(Properties.Settings.Default.DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query;

                if (isEditMode)
                {
                    query =
                        "UPDATE Groups SET " +
                        "GroupName=@groupName, " +
                        "StartDate=@startDate, " +
                        "EndDate=@endDate, " +
                        "ProgramID=@programId " +
                        "WHERE GroupID=@id";
                }
                else
                {
                    query =
                        "INSERT INTO Groups " +
                        "(GroupName, StartDate, EndDate, ProgramID) " +
                        "VALUES " +
                        "(@groupName, @startDate, @endDate, @programId)";
                }

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@groupName", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@startDate", dtBirthDate.Value);
                cmd.Parameters.AddWithValue("@endDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@programId", comboBoxGroup.SelectedValue);
    
                if (isEditMode)
                    cmd.Parameters.AddWithValue("@id", groupId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Сохранено");
            this.Close();
        }

        private int groupId;
        private bool isEditMode = false;

        public ManageGroupsForm(int id)
        {
            InitializeComponent();

            groupId = id;
            isEditMode = true;

            LoadPrograms();
            LoadGroupData();
        }

        private void LoadGroupData()
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query =
                    "SELECT * FROM Groups WHERE GroupID = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", groupId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBoxLastName.Text = reader["GroupName"].ToString();
                    dtBirthDate.Value = Convert.ToDateTime(reader["StartDate"]);
                    dateTimePicker1.Value = Convert.ToDateTime(reader["EndDate"]);
                    comboBoxGroup.SelectedValue = reader["ProgramID"];
                }
            }
        }

        private void LoadPrograms()
        {
            using (SqlConnection con =
                new SqlConnection(Properties.Settings.Default.DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query =
                    "SELECT ProgramID, ProgramName FROM Programs";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable table = new DataTable();
                adapter.Fill(table);

                comboBoxGroup.DataSource = table;
                comboBoxGroup.DisplayMember = "ProgramName";
                comboBoxGroup.ValueMember = "ProgramID";
            }
        }
    }
}
