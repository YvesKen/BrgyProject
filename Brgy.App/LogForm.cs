using System;
using System.Windows.Forms;
using Brgy.Domain;
using Brgy.Service;
using MaterialSkin.Controls;

namespace Brgy.App
{
    public partial class LogForm : MaterialForm
    {
        private readonly AuthService _authService = new AuthService();

        public LogForm() { InitializeComponent(); }

        private void materialButton1_Click(object sender, EventArgs e) // Your Login Button
        {
            Account user = _authService.VerifyUser(txtUser.Text, txtPass.Text);

            if (user != null)
            {
                new PublicDashboard(user.IsOfficial).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }
    }
}