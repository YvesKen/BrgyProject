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

            // Initialize MaterialSkin
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Teal Color Scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal600, Primary.Teal700,
                Primary.Teal200, Accent.Teal400,
                TextShade.WHITE
            );

            // Hide Tab Headers from the main white area
            materialTabControl1.SizeMode = TabSizeMode.Fixed;
            materialTabControl1.ItemSize = new Size(0, 1);
        }

        private void PublicDashboard_Load(object sender, EventArgs e)
        {
            // If the user is a Resident (NOT an official)
            if (!_isOfficial)
            {
                // 1. Remove by Name (if matches property)
                if (materialTabControl1.TabPages.Contains(tabPageAnnouncement))
                {
                    materialTabControl1.TabPages.Remove(tabPageAnnouncement);
                }

                // 2. Fail-safe: Search every tab for the announcement label
                // This removes the tab based on the text you see on screen
                for (int i = materialTabControl1.TabPages.Count - 1; i >= 0; i--)
                {
                    TabPage tab = materialTabControl1.TabPages[i];
                    // Check if it's the 3rd tab or has the name you gave it
                    if (tab.Text.Contains("tabPage3") || tab.Name == "tabPageAnnouncement")
                    {
                        materialTabControl1.TabPages.Remove(tab);
                    }
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            ofdUpload.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofdUpload.ShowDialog() == DialogResult.OK)
            {
                picPreview.Image = Image.FromFile(ofdUpload.FileName);
                picPreview.Tag = ofdUpload.FileName;
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (picPreview.Image != null)
            {
                MessageBox.Show("Announcement Posted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please upload an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}