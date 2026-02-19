namespace Brgy.App
{
    partial class RegisterForm
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            txtSecretCode = new TextBox();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(93, 105);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(97, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Special Code:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(98, 169);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(71, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Fullname:";
            materialLabel2.Click += materialLabel2_Click;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(93, 233);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(76, 19);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "Username:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(93, 296);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(75, 19);
            materialLabel4.TabIndex = 3;
            materialLabel4.Text = "Password:";
            // 
            // txtSecretCode
            // 
            txtSecretCode.Location = new Point(210, 103);
            txtSecretCode.Name = "txtSecretCode";
            txtSecretCode.Size = new Size(405, 23);
            txtSecretCode.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(210, 169);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(405, 23);
            txtFullName.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(210, 231);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(405, 23);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(210, 292);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(405, 23);
            txtPassword.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegister.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegister.Depth = 0;
            btnRegister.HighEmphasis = true;
            btnRegister.Icon = null;
            btnRegister.Location = new Point(337, 352);
            btnRegister.Margin = new Padding(4, 6, 4, 6);
            btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegister.Name = "btnRegister";
            btnRegister.NoAccentTextColor = Color.Empty;
            btnRegister.Size = new Size(89, 36);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "REGISTER";
            btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegister.UseAccentColor = false;
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            Controls.Add(txtSecretCode);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Name = "RegisterForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private TextBox txtSecretCode;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private MaterialSkin.Controls.MaterialButton btnRegister;
    }
}