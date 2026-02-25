using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Brgy.App
{
    public partial class PublicDashboard : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        bool _isOfficial = false;

        public PublicDashboard(bool userIsOfficial)
        {
            InitializeComponent();
            _isOfficial = userIsOfficial;

        
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal600, Primary.Teal700,
                Primary.Teal200, Accent.Teal400,
                TextShade.WHITE
            );

            materialTabControl1.SizeMode = TabSizeMode.Fixed;
            materialTabControl1.ItemSize = new Size(0, 1);

        
            ApplyAccessControl();
        }

        private void ApplyAccessControl()
        {
            if (!_isOfficial)
            {
              
                btnUpload.Visible = false;
                btnPost.Visible = false;

                txtAnnouncement.ReadOnly = true;

      
                txtAnnouncement.Cursor = Cursors.Arrow;
                txtAnnouncement.Enter += (s, e) => { this.ActiveControl = null; };
            }
            else
            {
       
                btnUpload.Visible = true;
                btnPost.Visible = true;
                txtAnnouncement.ReadOnly = false;
                txtAnnouncement.Cursor = Cursors.IBeam;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Barangay System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
           
                Application.Restart();
            }
        }

        // --- UPLOAD BUTTON LOGIC ---
        private void btnUpload_Click(object sender, EventArgs e)
        {
            ofdUpload.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofdUpload.ShowDialog() == DialogResult.OK)
            {
                picPreview.Image = Image.FromFile(ofdUpload.FileName);
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (picPreview.Image != null || !string.IsNullOrWhiteSpace(txtAnnouncement.Text))
            {
                MessageBox.Show("Announcement Posted Successfully!", "Barangay System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please add an image or text first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabPageAnnouncement_Click(object sender, EventArgs e) { }
    }
}