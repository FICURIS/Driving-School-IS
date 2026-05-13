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
    public partial class ManageStudentsForm : Form
    {
        public ManageStudentsForm()
        {
            InitializeComponent();
            LoadGroups();
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
                        "UPDATE Students SET " +
                        "LastName=@lastName, " +
                        "FirstName=@firstName, " +
                        "MiddleName=@middleName, " +
                        "BirthDate=@birthDate, " +
                        "PhoneNumber=@phone, " +
                        "Email=@email, " +
                        "Address=@address, " +
                        "GroupID=@groupId " +
                        "WHERE StudentID=@id";
                }
                else
                {
                    query =
                        "INSERT INTO Students " +
                        "(LastName, FirstName, MiddleName, BirthDate, PhoneNumber, Email, Address, GroupID) " +
                        "VALUES " +
                        "(@lastName, @firstName, @middleName, @birthDate, @phone, @email, @address, @groupId)";
                }

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@lastName", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@firstName", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@middleName", textBoxMiddleName.Text);
                cmd.Parameters.AddWithValue("@birthDate", dtBirthDate.Value);
                cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@address", textBoxAddress.Text);
                cmd.Parameters.AddWithValue("@groupId", comboBoxGroup.SelectedValue);

                if (isEditMode)
                    cmd.Parameters.AddWithValue("@id", studentId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Сохранено");
            this.Close();
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadGroups()
        {
            using (SqlConnection con =
                new SqlConnection(
                Properties.Settings.Default
                .DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query =
                    "SELECT GroupID, GroupName FROM Groups";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, con);

                DataTable table = new DataTable();

                adapter.Fill(table);

                comboBoxGroup.DataSource = table;

                comboBoxGroup.DisplayMember = "GroupName";

                comboBoxGroup.ValueMember = "GroupID";
            }
        }

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {

        }

        private int studentId;
        private bool isEditMode = false;

        public ManageStudentsForm(int id)
        {
            InitializeComponent();

            studentId = id;
            isEditMode = true;

            LoadGroups();
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query =
                    "SELECT * FROM Students WHERE StudentID = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", studentId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    textBoxLastName.Text = reader["LastName"].ToString();
                    textBoxFirstName.Text = reader["FirstName"].ToString();
                    textBoxMiddleName.Text = reader["MiddleName"].ToString();
                    dtBirthDate.Value = Convert.ToDateTime(reader["BirthDate"]);
                    textBoxPhone.Text = reader["PhoneNumber"].ToString();
                    textBoxEmail.Text = reader["Email"].ToString();
                    textBoxAddress.Text = reader["Address"].ToString();
                    comboBoxGroup.SelectedValue = reader["GroupID"];
                }
            }
        }
    }
}
