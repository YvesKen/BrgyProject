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
            pictureBox1 = new PictureBox();
            btnPost = new MaterialSkin.Controls.MaterialButton();
            txtAnnouncement = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            picPreview = new PictureBox();
            btnUpload = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            ofdUpload = new OpenFileDialog();
            btnLogout = new Button();
            materialTabControl1.SuspendLayout();
            tabPageAnnouncement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
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
            materialTabControl1.Size = new Size(794, 416);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPageAnnouncement
            // 
            tabPageAnnouncement.Controls.Add(pictureBox1);
            tabPageAnnouncement.Controls.Add(btnPost);
            tabPageAnnouncement.Controls.Add(txtAnnouncement);
            tabPageAnnouncement.Controls.Add(picPreview);
            tabPageAnnouncement.Controls.Add(btnUpload);
            tabPageAnnouncement.Controls.Add(label1);
            tabPageAnnouncement.Location = new Point(4, 24);
            tabPageAnnouncement.Name = "tabPageAnnouncement";
            tabPageAnnouncement.Padding = new Padding(3);
            tabPageAnnouncement.Size = new Size(786, 388);
            tabPageAnnouncement.TabIndex = 0;
            tabPageAnnouncement.Text = "Home";
            tabPageAnnouncement.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(82, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 95);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnPost
            // 
            btnPost.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPost.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPost.Depth = 0;
            btnPost.HighEmphasis = true;
            btnPost.Icon = null;
            btnPost.Location = new Point(64, 300);
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
            btnPost.Click += btnPost_Click;
            // 
            // txtAnnouncement
            // 
            txtAnnouncement.BackColor = Color.FromArgb(255, 255, 255);
            txtAnnouncement.BorderStyle = BorderStyle.None;
            txtAnnouncement.Depth = 0;
            txtAnnouncement.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAnnouncement.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtAnnouncement.Location = new Point(17, 182);
            txtAnnouncement.MouseState = MaterialSkin.MouseState.HOVER;
            txtAnnouncement.Name = "txtAnnouncement";
            txtAnnouncement.Size = new Size(289, 86);
            txtAnnouncement.TabIndex = 4;
            txtAnnouncement.Text = "";
            txtAnnouncement.TextChanged += txtAnnouncement_TextChanged;
            // 
            // picPreview
            // 
            picPreview.Location = new Point(323, 34);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(429, 234);
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
            btnUpload.Location = new Point(482, 300);
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
            label1.Location = new Point(42, 143);
            label1.Name = "label1";
            label1.Size = new Size(176, 15);
            label1.TabIndex = 1;
            label1.Text = "Barangay Poblacion Population";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 388);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Documents";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(786, 388);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Request";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(786, 388);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Officials";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // ofdUpload
            // 
            ofdUpload.FileName = "openFileDialog1";
            ofdUpload.FileOk += ofdUpload_FileOk;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.MidnightBlue;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(760, 35);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(33, 23);
            btnLogout.TabIndex = 1;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // PublicDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 483);
            Controls.Add(btnLogout);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "PublicDashboard";
            Text = "PublicDashboard";
            materialTabControl1.ResumeLayout(false);
            tabPageAnnouncement.ResumeLayout(false);
            tabPageAnnouncement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
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
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtAnnouncement;
        private PictureBox picPreview;
        private OpenFileDialog ofdUpload;
        private Button btnLogout;
    }
}