namespace Brgy.App
{
    partial class PublicDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublicDashboard));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPageAnnouncement = new TabPage();
            btnPost = new MaterialSkin.Controls.MaterialButton();
            materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            picPreview = new PictureBox();
            btnUpload = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            ofdUpload = new OpenFileDialog();
            materialTabControl1.SuspendLayout();
            tabPageAnnouncement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPageAnnouncement);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(tabPage4);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(794, 383);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPageAnnouncement
            // 
            tabPageAnnouncement.Controls.Add(btnPost);
            tabPageAnnouncement.Controls.Add(materialMultiLineTextBox1);
            tabPageAnnouncement.Controls.Add(picPreview);
            tabPageAnnouncement.Controls.Add(btnUpload);
            tabPageAnnouncement.Controls.Add(label1);
            tabPageAnnouncement.Controls.Add(pictureBox1);
            tabPageAnnouncement.Location = new Point(4, 24);
            tabPageAnnouncement.Name = "tabPageAnnouncement";
            tabPageAnnouncement.Padding = new Padding(3);
            tabPageAnnouncement.Size = new Size(786, 355);
            tabPageAnnouncement.TabIndex = 0;
            tabPageAnnouncement.Text = "Home";
            tabPageAnnouncement.UseVisualStyleBackColor = true;
          
            // 
            // btnPost
            // 
            btnPost.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPost.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPost.Depth = 0;
            btnPost.HighEmphasis = true;
            btnPost.Icon = null;
            btnPost.Location = new Point(295, 175);
            btnPost.Margin = new Padding(4, 6, 4, 6);
            btnPost.MouseState = MaterialSkin.MouseState.HOVER;
            btnPost.Name = "btnPost";
            btnPost.NoAccentTextColor = Color.Empty;
            btnPost.Size = new Size(64, 36);
            btnPost.TabIndex = 5;
            btnPost.Text = "Post";
            btnPost.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPost.UseAccentColor = false;
            btnPost.UseVisualStyleBackColor = true;
            // 
            // materialMultiLineTextBox1
            // 
            materialMultiLineTextBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox1.BorderStyle = BorderStyle.None;
            materialMultiLineTextBox1.Depth = 0;
            materialMultiLineTextBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox1.Location = new Point(265, 28);
            materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            materialMultiLineTextBox1.Size = new Size(100, 96);
            materialMultiLineTextBox1.TabIndex = 4;
            materialMultiLineTextBox1.Text = "";
            // 
            // picPreview
            // 
            picPreview.Location = new Point(470, 28);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(100, 50);
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPreview.TabIndex = 3;
            picPreview.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpload.Depth = 0;
            btnUpload.HighEmphasis = true;
            btnUpload.Icon = null;
            btnUpload.Location = new Point(458, 175);
            btnUpload.Margin = new Padding(4, 6, 4, 6);
            btnUpload.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpload.Name = "btnUpload";
            btnUpload.NoAccentTextColor = Color.Empty;
            btnUpload.Size = new Size(123, 36);
            btnUpload.TabIndex = 2;
            btnUpload.Text = "Select Image";
            btnUpload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpload.UseAccentColor = false;
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 109);
            label1.Name = "label1";
            label1.Size = new Size(176, 15);
            label1.TabIndex = 1;
            label1.Text = "Barangay Poblacion Population";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(43, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 91);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 355);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Documents";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(786, 355);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Request";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(786, 355);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Officials";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // ofdUpload
            // 
            ofdUpload.FileName = "openFileDialog1";
            // 
            // PublicDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "PublicDashboard";
            Text = "PublicDashboard";
            materialTabControl1.ResumeLayout(false);
            tabPageAnnouncement.ResumeLayout(false);
            tabPageAnnouncement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPageAnnouncement;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnUpload;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton btnPost;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private PictureBox picPreview;
        private OpenFileDialog ofdUpload;
    }
}