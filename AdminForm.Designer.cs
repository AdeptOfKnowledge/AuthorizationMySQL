namespace Authorization
{
    partial class AdminForm
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
            this.UserSearching = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Search_Button = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RenameUsrButton = new System.Windows.Forms.Button();
            this.superAdminButton = new System.Windows.Forms.CheckBox();
            this.AdminButton = new System.Windows.Forms.CheckBox();
            this.superAdminBehindBox = new System.Windows.Forms.TextBox();
            this.DelUsrButton = new System.Windows.Forms.Button();
            this.AdminBehindBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AuthorizationText = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.ListBox();
            this.Logout = new System.Windows.Forms.PictureBox();
            this.adminName = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.Label();
            this.surnameField = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.Label();
            this.statusField = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_Button)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).BeginInit();
            this.SuspendLayout();
            // 
            // UserSearching
            // 
            this.UserSearching.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserSearching.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserSearching.Location = new System.Drawing.Point(2, 15);
            this.UserSearching.Name = "UserSearching";
            this.UserSearching.Size = new System.Drawing.Size(204, 22);
            this.UserSearching.TabIndex = 0;
            this.UserSearching.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserSearching_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Search_Button);
            this.groupBox4.Controls.Add(this.UserSearching);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox4.Location = new System.Drawing.Point(50, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 40);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search user:";
            // 
            // Search_Button
            // 
            this.Search_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Search_Button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_Button.Image = global::Authorization.Properties.Resources.right_arrow_1;
            this.Search_Button.Location = new System.Drawing.Point(184, 15);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(22, 22);
            this.Search_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Search_Button.TabIndex = 24;
            this.Search_Button.TabStop = false;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.RenameUsrButton);
            this.groupBox2.Controls.Add(this.superAdminButton);
            this.groupBox2.Controls.Add(this.AdminButton);
            this.groupBox2.Controls.Add(this.superAdminBehindBox);
            this.groupBox2.Controls.Add(this.DelUsrButton);
            this.groupBox2.Controls.Add(this.AdminBehindBox);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(297, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 264);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assign permissions";
            // 
            // RenameUsrButton
            // 
            this.RenameUsrButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RenameUsrButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RenameUsrButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.RenameUsrButton.FlatAppearance.BorderSize = 0;
            this.RenameUsrButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RenameUsrButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RenameUsrButton.ForeColor = System.Drawing.Color.DarkRed;
            this.RenameUsrButton.Location = new System.Drawing.Point(50, 142);
            this.RenameUsrButton.Name = "RenameUsrButton";
            this.RenameUsrButton.Size = new System.Drawing.Size(107, 32);
            this.RenameUsrButton.TabIndex = 26;
            this.RenameUsrButton.Text = "Rename user";
            this.RenameUsrButton.UseVisualStyleBackColor = false;
            this.RenameUsrButton.Click += new System.EventHandler(this.RenameUsrButton_Click);
            // 
            // superAdminButton
            // 
            this.superAdminButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.superAdminButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.superAdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.superAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.superAdminButton.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.superAdminButton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.superAdminButton.Location = new System.Drawing.Point(50, 91);
            this.superAdminButton.Name = "superAdminButton";
            this.superAdminButton.Size = new System.Drawing.Size(107, 32);
            this.superAdminButton.TabIndex = 24;
            this.superAdminButton.Text = "superadmin";
            this.superAdminButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.superAdminButton.ThreeState = true;
            this.superAdminButton.UseVisualStyleBackColor = true;
            this.superAdminButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.superAdminButton_MouseClick);
            // 
            // AdminButton
            // 
            this.AdminButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.AdminButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdminButton.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.AdminButton.ForeColor = System.Drawing.Color.Blue;
            this.AdminButton.Location = new System.Drawing.Point(50, 42);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(107, 32);
            this.AdminButton.TabIndex = 24;
            this.AdminButton.Text = "admin";
            this.AdminButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminButton.ThreeState = true;
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AdminButton_MouseClick);
            // 
            // superAdminBehindBox
            // 
            this.superAdminBehindBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.superAdminBehindBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.superAdminBehindBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.superAdminBehindBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.superAdminBehindBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.superAdminBehindBox.Location = new System.Drawing.Point(50, 91);
            this.superAdminBehindBox.Multiline = true;
            this.superAdminBehindBox.Name = "superAdminBehindBox";
            this.superAdminBehindBox.Size = new System.Drawing.Size(107, 32);
            this.superAdminBehindBox.TabIndex = 25;
            this.superAdminBehindBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.superAdminBehindBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.superAdminBehindBox_MouseClick);
            // 
            // DelUsrButton
            // 
            this.DelUsrButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DelUsrButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelUsrButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.DelUsrButton.FlatAppearance.BorderSize = 0;
            this.DelUsrButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelUsrButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelUsrButton.ForeColor = System.Drawing.Color.DarkRed;
            this.DelUsrButton.Location = new System.Drawing.Point(50, 193);
            this.DelUsrButton.Name = "DelUsrButton";
            this.DelUsrButton.Size = new System.Drawing.Size(107, 32);
            this.DelUsrButton.TabIndex = 16;
            this.DelUsrButton.Text = "Delete user";
            this.DelUsrButton.UseVisualStyleBackColor = false;
            this.DelUsrButton.Click += new System.EventHandler(this.DelUsrButton_Click);
            // 
            // AdminBehindBox
            // 
            this.AdminBehindBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AdminBehindBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminBehindBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminBehindBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminBehindBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AdminBehindBox.Location = new System.Drawing.Point(50, 42);
            this.AdminBehindBox.Multiline = true;
            this.AdminBehindBox.Name = "AdminBehindBox";
            this.AdminBehindBox.Size = new System.Drawing.Size(107, 32);
            this.AdminBehindBox.TabIndex = 25;
            this.AdminBehindBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AdminBehindBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AdminBehindBox_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.statusField);
            this.groupBox1.Controls.Add(this.loginField);
            this.groupBox1.Controls.Add(this.surnameField);
            this.groupBox1.Controls.Add(this.nameField);
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.loginLabel);
            this.groupBox1.Controls.Add(this.surnameLabel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(542, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 264);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User information";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.Color.Black;
            this.statusLabel.Location = new System.Drawing.Point(1, 193);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(81, 32);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "Status:";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.Black;
            this.loginLabel.Location = new System.Drawing.Point(1, 144);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(81, 32);
            this.loginLabel.TabIndex = 16;
            this.loginLabel.Text = "Login:";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // surnameLabel
            // 
            this.surnameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.ForeColor = System.Drawing.Color.Black;
            this.surnameLabel.Location = new System.Drawing.Point(1, 94);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(81, 32);
            this.surnameLabel.TabIndex = 16;
            this.surnameLabel.Text = "Surname:";
            this.surnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(1, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(81, 32);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit.Location = new System.Drawing.Point(767, 1);
            this.Exit.Margin = new System.Windows.Forms.Padding(1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(32, 34);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "x";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.AuthorizationText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 17;
            // 
            // AuthorizationText
            // 
            this.AuthorizationText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AuthorizationText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AuthorizationText.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.AuthorizationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthorizationText.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AuthorizationText.Location = new System.Drawing.Point(0, 0);
            this.AuthorizationText.Name = "AuthorizationText";
            this.AuthorizationText.Size = new System.Drawing.Size(800, 100);
            this.AuthorizationText.TabIndex = 0;
            this.AuthorizationText.Text = "Admin settings";
            this.AuthorizationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AuthorizationText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthorizationText_MouseDown);
            this.AuthorizationText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AuthorizationText_MouseMove);
            // 
            // Users
            // 
            this.Users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Users.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Users.FormattingEnabled = true;
            this.Users.ItemHeight = 21;
            this.Users.Location = new System.Drawing.Point(50, 151);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(208, 254);
            this.Users.TabIndex = 15;
            this.Users.SelectedIndexChanged += new System.EventHandler(this.Users_SelectedIndexChanged);
            // 
            // Logout
            // 
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.Image = global::Authorization.Properties.Resources.logout;
            this.Logout.Location = new System.Drawing.Point(725, 116);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(25, 25);
            this.Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logout.TabIndex = 22;
            this.Logout.TabStop = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // adminName
            // 
            this.adminName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminName.ForeColor = System.Drawing.Color.Teal;
            this.adminName.Location = new System.Drawing.Point(542, 118);
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(178, 22);
            this.adminName.TabIndex = 23;
            this.adminName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.ForeColor = System.Drawing.Color.Black;
            this.nameField.Location = new System.Drawing.Point(71, 52);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(131, 22);
            this.nameField.TabIndex = 24;
            this.nameField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surnameField
            // 
            this.surnameField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameField.ForeColor = System.Drawing.Color.Black;
            this.surnameField.Location = new System.Drawing.Point(71, 100);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(131, 22);
            this.surnameField.TabIndex = 25;
            this.surnameField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.ForeColor = System.Drawing.Color.Teal;
            this.loginField.Location = new System.Drawing.Point(71, 150);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(131, 22);
            this.loginField.TabIndex = 26;
            this.loginField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusField
            // 
            this.statusField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.statusField.Location = new System.Drawing.Point(71, 199);
            this.statusField.Name = "statusField";
            this.statusField.Size = new System.Drawing.Size(131, 22);
            this.statusField.TabIndex = 27;
            this.statusField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminName);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_Button)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UserSearching;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox Logout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AuthorizationText;
        private System.Windows.Forms.ListBox Users;
        private System.Windows.Forms.Button DelUsrButton;
        private System.Windows.Forms.CheckBox AdminButton;
        private System.Windows.Forms.TextBox AdminBehindBox;
        private System.Windows.Forms.CheckBox superAdminButton;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.PictureBox Search_Button;
        private System.Windows.Forms.Button RenameUsrButton;
        private System.Windows.Forms.TextBox superAdminBehindBox;
        private System.Windows.Forms.Label adminName;
        private System.Windows.Forms.Label nameField;
        private System.Windows.Forms.Label surnameField;
        private System.Windows.Forms.Label loginField;
        private System.Windows.Forms.Label statusField;
    }
}