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
    public partial class ManageInstructorsForm : Form
    {
        public ManageInstructorsForm()
        {
            InitializeComponent();
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
                        "UPDATE Instructors SET " +
                        "LastName=@lastName, " +
                        "FirstName=@firstName, " +
                        "MiddleName=@middleName, " +
                        "PhoneNumber=@phone " +
                        "WHERE InstructorID=@id";
                }
                else
                {
                    query =
                        "INSERT INTO Instructors " +
                        "(LastName, FirstName, MiddleName, PhoneNumber) " +
                        "VALUES " +
                        "(@lastName, @firstName, @middleName, @phone)";
                }

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@lastName", textBoxLastName.Text);
                cmd.Parameters.AddWithValue("@firstName", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@middleName", textBoxMiddleName.Text);
                cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);

                if (isEditMode)
                    cmd.Parameters.AddWithValue("@id", instructorId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Сохранено");
            this.Close();
        }

        private int instructorId;
        private bool isEditMode = false;

        public ManageInstructorsForm(int id)
        {
            InitializeComponent();

            instructorId = id;
            isEditMode = true;

            LoadInstructorData();
        }

        private void LoadInstructorData()
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query =
                    "SELECT * FROM Instructors WHERE InstructorID = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", instructorId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBoxLastName.Text = reader["LastName"].ToString();
                    textBoxFirstName.Text = reader["FirstName"].ToString();
                    textBoxMiddleName.Text = reader["MiddleName"].ToString();
                    textBoxPhone.Text = reader["PhoneNumber"].ToString();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
