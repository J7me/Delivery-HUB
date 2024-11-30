namespace DeliveryHUB
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
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.lbMessError = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.FirstName = new MaterialSkin.Controls.MaterialLabel();
            this.LastName = new MaterialSkin.Controls.MaterialLabel();
            this.LbPhone = new MaterialSkin.Controls.MaterialLabel();
            this.LbEmail = new MaterialSkin.Controls.MaterialLabel();
            this.LbLogin = new MaterialSkin.Controls.MaterialLabel();
            this.LbPasswd = new MaterialSkin.Controls.MaterialLabel();
            this.txtFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegister = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(150, 482);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(191, 36);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseAccent = false;
            this.txtPassword.UseTallSize = false;
            // 
            // lbMessError
            // 
            this.lbMessError.AutoSize = true;
            this.lbMessError.ForeColor = System.Drawing.Color.Red;
            this.lbMessError.Location = new System.Drawing.Point(79, 597);
            this.lbMessError.Name = "lbMessError";
            this.lbMessError.Size = new System.Drawing.Size(40, 13);
            this.lbMessError.TabIndex = 8;
            this.lbMessError.Text = "lbMess";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(180, 235);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(120, 24);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Регистрация";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Depth = 0;
            this.FirstName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FirstName.Location = new System.Drawing.Point(112, 289);
            this.FirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(33, 19);
            this.FirstName.TabIndex = 11;
            this.FirstName.Text = "Имя";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Depth = 0;
            this.LastName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LastName.Location = new System.Drawing.Point(75, 329);
            this.LastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(70, 19);
            this.LastName.TabIndex = 12;
            this.LastName.Text = "Фамилия";
            // 
            // LbPhone
            // 
            this.LbPhone.AutoSize = true;
            this.LbPhone.Depth = 0;
            this.LbPhone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LbPhone.Location = new System.Drawing.Point(79, 373);
            this.LbPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbPhone.Name = "LbPhone";
            this.LbPhone.Size = new System.Drawing.Size(66, 19);
            this.LbPhone.TabIndex = 13;
            this.LbPhone.Text = "Телефон";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Depth = 0;
            this.LbEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LbEmail.Location = new System.Drawing.Point(97, 415);
            this.LbEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(47, 19);
            this.LbEmail.TabIndex = 14;
            this.LbEmail.Text = "Почта";
            // 
            // LbLogin
            // 
            this.LbLogin.AutoSize = true;
            this.LbLogin.Depth = 0;
            this.LbLogin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LbLogin.Location = new System.Drawing.Point(99, 457);
            this.LbLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbLogin.Name = "LbLogin";
            this.LbLogin.Size = new System.Drawing.Size(46, 19);
            this.LbLogin.TabIndex = 15;
            this.LbLogin.Text = "Логин";
            // 
            // LbPasswd
            // 
            this.LbPasswd.AutoSize = true;
            this.LbPasswd.Depth = 0;
            this.LbPasswd.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LbPasswd.Location = new System.Drawing.Point(88, 499);
            this.LbPasswd.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbPasswd.Name = "LbPasswd";
            this.LbPasswd.Size = new System.Drawing.Size(57, 19);
            this.LbPasswd.TabIndex = 16;
            this.LbPasswd.Text = "Пароль";
            // 
            // txtFirstName
            // 
            this.txtFirstName.AnimateReadOnly = false;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFirstName.LeadingIcon = null;
            this.txtFirstName.Location = new System.Drawing.Point(151, 272);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(191, 36);
            this.txtFirstName.TabIndex = 17;
            this.txtFirstName.Text = "";
            this.txtFirstName.TrailingIcon = null;
            this.txtFirstName.UseAccent = false;
            this.txtFirstName.UseTallSize = false;
            // 
            // txtLastName
            // 
            this.txtLastName.AnimateReadOnly = false;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Depth = 0;
            this.txtLastName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastName.LeadingIcon = null;
            this.txtLastName.Location = new System.Drawing.Point(151, 314);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(191, 36);
            this.txtLastName.TabIndex = 18;
            this.txtLastName.Text = "";
            this.txtLastName.TrailingIcon = null;
            this.txtLastName.UseAccent = false;
            this.txtLastName.UseTallSize = false;
            // 
            // txtPhone
            // 
            this.txtPhone.AnimateReadOnly = false;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Depth = 0;
            this.txtPhone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.LeadingIcon = null;
            this.txtPhone.Location = new System.Drawing.Point(151, 356);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(191, 36);
            this.txtPhone.TabIndex = 19;
            this.txtPhone.Text = "";
            this.txtPhone.TrailingIcon = null;
            this.txtPhone.UseAccent = false;
            this.txtPhone.UseTallSize = false;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(150, 398);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 36);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseAccent = false;
            this.txtEmail.UseTallSize = false;
            // 
            // txtLogin
            // 
            this.txtLogin.AnimateReadOnly = false;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Depth = 0;
            this.txtLogin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLogin.LeadingIcon = null;
            this.txtLogin.Location = new System.Drawing.Point(150, 440);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLogin.Multiline = false;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(191, 36);
            this.txtLogin.TabIndex = 21;
            this.txtLogin.Text = "";
            this.txtLogin.TrailingIcon = null;
            this.txtLogin.UseAccent = false;
            this.txtLogin.UseTallSize = false;
            // 
            // pictureBox1
            // 
                     // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = false;
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegister.Depth = 0;
            this.btnRegister.HighEmphasis = true;
            this.btnRegister.Icon = null;
            this.btnRegister.Location = new System.Drawing.Point(150, 536);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegister.Size = new System.Drawing.Size(191, 36);
            this.btnRegister.TabIndex = 24;
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegister.UseAccentColor = false;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 697);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.LbPasswd);
            this.Controls.Add(this.LbLogin);
            this.Controls.Add(this.LbEmail);
            this.Controls.Add(this.LbPhone);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lbMessError);
            this.Name = "RegisterForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private System.Windows.Forms.Label lbMessError;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel FirstName;
        private MaterialSkin.Controls.MaterialLabel LastName;
        private MaterialSkin.Controls.MaterialLabel LbPhone;
        private MaterialSkin.Controls.MaterialLabel LbEmail;
        private MaterialSkin.Controls.MaterialLabel LbLogin;
        private MaterialSkin.Controls.MaterialLabel LbPasswd;
        private MaterialSkin.Controls.MaterialTextBox txtFirstName;
        private MaterialSkin.Controls.MaterialTextBox txtLastName;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnRegister;
    }
}