namespace CFPH_Dummy_Account_Creator
{
    partial class Main
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.label_status = new FlatUI.FlatLabel();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.button_createaccount = new FlatUI.FlatButton();
            this.label_Password = new FlatUI.FlatLabel();
            this.label_UserName = new FlatUI.FlatLabel();
            this.textbox_capcha = new FlatUI.FlatTextBox();
            this.textbox_password = new FlatUI.FlatTextBox();
            this.textbox_username = new FlatUI.FlatTextBox();
            this.flatClose1 = new FlatUI.FlatClose();
            this.formSkin1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.flatLabel1);
            this.formSkin1.Controls.Add(this.label_status);
            this.formSkin1.Controls.Add(this.picturebox);
            this.formSkin1.Controls.Add(this.browser);
            this.formSkin1.Controls.Add(this.button_createaccount);
            this.formSkin1.Controls.Add(this.label_Password);
            this.formSkin1.Controls.Add(this.label_UserName);
            this.formSkin1.Controls.Add(this.textbox_capcha);
            this.formSkin1.Controls.Add(this.textbox_password);
            this.formSkin1.Controls.Add(this.textbox_username);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(311, 256);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "CFPH Dummy Account Creator";
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(58, 235);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(175, 13);
            this.flatLabel1.TabIndex = 7;
            this.flatLabel1.Text = "Created by: Ryuzaki™ / Geopulse";
            // 
            // label_status
            // 
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.White;
            this.label_status.Location = new System.Drawing.Point(63, 162);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(164, 23);
            this.label_status.TabIndex = 6;
            this.label_status.Text = "Status: Idle";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picturebox
            // 
            this.picturebox.Location = new System.Drawing.Point(33, 129);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(130, 25);
            this.picturebox.TabIndex = 5;
            this.picturebox.TabStop = false;
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(357, 126);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(322, 339);
            this.browser.TabIndex = 4;
            this.browser.Url = new System.Uri("https://mem.ph.gameclub.com/Member/Join/UserAgreeFrm.asp", System.UriKind.Absolute);
            this.browser.Visible = false;
            // 
            // button_createaccount
            // 
            this.button_createaccount.BackColor = System.Drawing.Color.Transparent;
            this.button_createaccount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button_createaccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_createaccount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_createaccount.Location = new System.Drawing.Point(78, 190);
            this.button_createaccount.Name = "button_createaccount";
            this.button_createaccount.Rounded = false;
            this.button_createaccount.Size = new System.Drawing.Size(134, 32);
            this.button_createaccount.TabIndex = 3;
            this.button_createaccount.Text = "Create Account";
            this.button_createaccount.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_createaccount.Click += new System.EventHandler(this.button_createaccount_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.Transparent;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.Color.White;
            this.label_Password.Location = new System.Drawing.Point(30, 93);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(105, 30);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password:";
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.BackColor = System.Drawing.Color.Transparent;
            this.label_UserName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.ForeColor = System.Drawing.Color.White;
            this.label_UserName.Location = new System.Drawing.Point(28, 58);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(111, 30);
            this.label_UserName.TabIndex = 2;
            this.label_UserName.Text = "Username:";
            // 
            // textbox_capcha
            // 
            this.textbox_capcha.BackColor = System.Drawing.Color.Transparent;
            this.textbox_capcha.Enabled = false;
            this.textbox_capcha.FocusOnHover = false;
            this.textbox_capcha.Location = new System.Drawing.Point(169, 127);
            this.textbox_capcha.MaxLength = 32767;
            this.textbox_capcha.Multiline = false;
            this.textbox_capcha.Name = "textbox_capcha";
            this.textbox_capcha.ReadOnly = false;
            this.textbox_capcha.Size = new System.Drawing.Size(104, 29);
            this.textbox_capcha.TabIndex = 1;
            this.textbox_capcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_capcha.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textbox_capcha.UseSystemPasswordChar = false;
            // 
            // textbox_password
            // 
            this.textbox_password.BackColor = System.Drawing.Color.Transparent;
            this.textbox_password.Enabled = false;
            this.textbox_password.FocusOnHover = false;
            this.textbox_password.Location = new System.Drawing.Point(151, 94);
            this.textbox_password.MaxLength = 32767;
            this.textbox_password.Multiline = false;
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.ReadOnly = false;
            this.textbox_password.Size = new System.Drawing.Size(122, 29);
            this.textbox_password.TabIndex = 1;
            this.textbox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_password.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textbox_password.UseSystemPasswordChar = false;
            // 
            // textbox_username
            // 
            this.textbox_username.BackColor = System.Drawing.Color.Transparent;
            this.textbox_username.Enabled = false;
            this.textbox_username.FocusOnHover = false;
            this.textbox_username.Location = new System.Drawing.Point(151, 59);
            this.textbox_username.MaxLength = 32767;
            this.textbox_username.Multiline = false;
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.ReadOnly = false;
            this.textbox_username.Size = new System.Drawing.Size(122, 29);
            this.textbox_username.TabIndex = 1;
            this.textbox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_username.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textbox_username.UseSystemPasswordChar = false;
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(281, 14);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 256);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatButton button_createaccount;
        private FlatUI.FlatLabel label_Password;
        private FlatUI.FlatLabel label_UserName;
        private FlatUI.FlatTextBox textbox_password;
        private FlatUI.FlatTextBox textbox_username;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.PictureBox picturebox;
        private FlatUI.FlatLabel label_status;
        private FlatUI.FlatTextBox textbox_capcha;
        private FlatUI.FlatLabel flatLabel1;


    }
}

