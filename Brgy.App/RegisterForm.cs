using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Brgy.Domain;


namespace Brgy.App
{
    public partial class RegisterForm : MaterialForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 1. Define your Secret Official Code
            string officialSecretKey = "Honey123";

            // 2. Check the code first
            if (txtSecretCode.Text != officialSecretKey)
            {
                MessageBox.Show("Invalid Official Code! You are not authorized to create an account.");
                return;
            }

            // 3. Use your Domain Class (Professor's Requirement)
            Account newOfficial = new Account
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                FullName = txtFullName.Text,
                Code = txtSecretCode.Text
            };

            // 4. Setup the Connection String
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BrgyDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // 5. Create the command INSIDE the using block
                string query = "INSERT INTO Accounts (Username, Password, FullName, CODE) VALUES (@user, @pass, @name, @code)";
                SqlCommand cmd = new SqlCommand(query, conn);

                // 6. Map the parameters using your Domain Object
                cmd.Parameters.AddWithValue("@user", newOfficial.Username);
                cmd.Parameters.AddWithValue("@pass", newOfficial.Password);
                cmd.Parameters.AddWithValue("@name", newOfficial.FullName);
                cmd.Parameters.AddWithValue("@code", newOfficial.Code);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Official Account Created Successfully!");

                    // 7. Redirection Logic
                    LogForm login = new LogForm();
                    login.Show();

                    // 8. Close the registration form
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Catches "Invalid column name 'CODE'" if DB isn't updated
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}




