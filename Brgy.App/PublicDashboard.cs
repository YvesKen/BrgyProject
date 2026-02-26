using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Brgy.App
{
    public partial class PublicDashboard : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private bool _isOfficial;

        public PublicDashboard(bool userIsOfficial)
        {
            InitializeComponent();
            _isOfficial = userIsOfficial;

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal700, Primary.Teal200, Accent.Teal400, TextShade.WHITE);

            ApplyAccessControl();
        }

        private void ApplyAccessControl()
        {
     
            btnPost.Visible = _isOfficial;
            btnUpload.Visible = _isOfficial;
            btnLogout.Visible = true;

  
            string savedText = Properties.Settings.Default.LastPostText;
            if (savedText != null)
            {
                savedText = savedText.Trim(); 
            }
            txtAnnouncement.Text = savedText;

            if (_isOfficial)
            {
               
                txtAnnouncement.Visible = true;
                txtAnnouncement.ReadOnly = false;
            }
            else
            {
              
                txtAnnouncement.ReadOnly = true;
                txtAnnouncement.Visible = !string.IsNullOrWhiteSpace(savedText);
            }

            string savedImagePath = Properties.Settings.Default.ImagePath;

            if (!string.IsNullOrEmpty(savedImagePath) && System.IO.File.Exists(savedImagePath))
            {
            
                picPreview.Image = Image.FromFile(savedImagePath);
                picPreview.Visible = true;
            }
            else
            {
          
                picPreview.Visible = _isOfficial;
            }
        }

        private void PublicDashboard_Load(object sender, EventArgs e)
        {
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LastPostText = txtAnnouncement.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Posted!");
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (ofdUpload.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = ofdUpload.FileName;

        
                picPreview.Image = Image.FromFile(selectedPath);

                Properties.Settings.Default.ImagePath = selectedPath;
                Properties.Settings.Default.Save();

                MessageBox.Show("Image saved successfully!");
            }
        }

      
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                new Entry().Show();
                this.Hide();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e) { }
        private void ofdUpload_FileOk(object sender, System.ComponentModel.CancelEventArgs e) { }
        private void txtAnnouncement_TextChanged(object sender, EventArgs e) { }
    }
}