using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Brgy.App
{
    public partial class LogForm : MaterialForm
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BrgyDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT COUNT(*) FROM Accounts WHERE Username=@user AND Password=@pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    PublicDashboard dash = new PublicDashboard(true); // Add 'true' here
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials.");
                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            // Redirect to the Login Form, NOT the Register Form
            RegisterForm login = new RegisterForm();
            login.Show();
            this.Hide();
        }
    }
}
