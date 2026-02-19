namespace Brgy.App
{
    partial class Entry
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPublic = new MaterialSkin.Controls.MaterialButton();
            btnAdmin = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // btnPublic
            // 
            btnPublic.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPublic.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPublic.Depth = 0;
            btnPublic.HighEmphasis = true;
            btnPublic.Icon = null;
            btnPublic.Location = new Point(456, 230);
            btnPublic.Margin = new Padding(4, 6, 4, 6);
            btnPublic.MouseState = MaterialSkin.MouseState.HOVER;
            btnPublic.Name = "btnPublic";
            btnPublic.NoAccentTextColor = Color.Empty;
            btnPublic.Size = new Size(153, 36);
            btnPublic.TabIndex = 0;
            btnPublic.Text = "PUBLIC / RESIDENT";
            btnPublic.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPublic.UseAccentColor = false;
            btnPublic.UseVisualStyleBackColor = true;
            btnPublic.Click += btnPublic_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdmin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdmin.Depth = 0;
            btnAdmin.HighEmphasis = true;
            btnAdmin.Icon = null;
            btnAdmin.Location = new Point(456, 299);
            btnAdmin.Margin = new Padding(4, 6, 4, 6);
            btnAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdmin.Name = "btnAdmin";
            btnAdmin.NoAccentTextColor = Color.Empty;
            btnAdmin.Size = new Size(144, 36);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "ADMIN / OFFICIAL";
            btnAdmin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdmin.UseAccentColor = false;
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // Entry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnAdmin);
            Controls.Add(btnPublic);
            Name = "Entry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barangay Information System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnPublic;
        private MaterialSkin.Controls.MaterialButton btnAdmin;
    }
}
