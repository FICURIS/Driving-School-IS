using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textLogin.Text == "" || textPassword.Text == "")
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            using (SqlConnection con = new SqlConnection(
                Properties.Settings.Default.DrivingSchoolDataBaseConnectionString))
            {
                con.Open();

                string query =
                    "SELECT * FROM Users " +
                    "WHERE Login = @login AND Password = @password";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@login", textLogin.Text);
                cmd.Parameters.AddWithValue("@password", textPassword.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    int roleId =
                        Convert.ToInt32(table.Rows[0]["RoleID"]);

                    if (roleId == 1)
                    {
                        MessageBox.Show("Вход как администратор");
                    }

                    if (roleId == 2)
                    {
                        MessageBox.Show("Вход как преподаватель");
                    }

                    if (roleId == 3)
                    {
                        MessageBox.Show("Вход как инструктор");
                    }

                    MainForm frm = new MainForm(textLogin.Text, roleId);

                    frm.Left = this.Left;
                    frm.Top = this.Top;

                    frm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
