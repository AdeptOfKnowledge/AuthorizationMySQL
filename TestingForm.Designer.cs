namespace Authorization
{
    partial class TestingForm
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
            this.TestingText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.StartTestButton = new System.Windows.Forms.Button();
            this.BD_label = new System.Windows.Forms.Label();
            this.UserCrLabel = new System.Windows.Forms.Label();
            this.EditLabel = new System.Windows.Forms.Label();
            this.CascadeLabel = new System.Windows.Forms.Label();
            this.DelUserLabel = new System.Windows.Forms.Label();
            this.BDconnection = new System.Windows.Forms.ProgressBar();
            this.OK_BD_Test = new System.Windows.Forms.Label();
            this.Failed_BD_test = new System.Windows.Forms.Label();
            this.TickBD = new System.Windows.Forms.PictureBox();
            this.PB_UserCr = new System.Windows.Forms.ProgressBar();
            this.OkUserTest = new System.Windows.Forms.Label();
            this.FailedUserTest = new System.Windows.Forms.Label();
            this.TickUserCreation = new System.Windows.Forms.PictureBox();
            this.PBEditUser = new System.Windows.Forms.ProgressBar();
            this.OkEditTest = new System.Windows.Forms.Label();
            this.FailedEditTest = new System.Windows.Forms.Label();
            this.TickEditUser = new System.Windows.Forms.PictureBox();
            this.TickCascade = new System.Windows.Forms.PictureBox();
            this.PBCascade = new System.Windows.Forms.ProgressBar();
            this.OkCascadeTest = new System.Windows.Forms.Label();
            this.FailedCascadeTest = new System.Windows.Forms.Label();
            this.TickDelUser = new System.Windows.Forms.PictureBox();
            this.PBDelUser = new System.Windows.Forms.ProgressBar();
            this.OkDelUserTest = new System.Windows.Forms.Label();
            this.FailedDelUserTest = new System.Windows.Forms.Label();
            this.GBCrossTests = new System.Windows.Forms.GroupBox();
            this.DeleteField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CascadeAdminField = new System.Windows.Forms.TextBox();
            this.CascadeUserField = new System.Windows.Forms.TextBox();
            this.ChangeLoginField = new System.Windows.Forms.TextBox();
            this.UserField = new System.Windows.Forms.TextBox();
            this.versionField = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.CrossLabel = new System.Windows.Forms.Label();
            this.ChangeTypeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDStartButton = new System.Windows.Forms.Button();
            this.IDTestLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SpellingStartButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.GBModulTest = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.FindInfoButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TickBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickUserCreation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickEditUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickCascade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickDelUser)).BeginInit();
            this.GBCrossTests.SuspendLayout();
            this.GBModulTest.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestingText
            // 
            this.TestingText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TestingText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TestingText.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.TestingText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestingText.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestingText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TestingText.Location = new System.Drawing.Point(0, 0);
            this.TestingText.Name = "TestingText";
            this.TestingText.Size = new System.Drawing.Size(727, 100);
            this.TestingText.TabIndex = 0;
            this.TestingText.Text = "Testing the system";
            this.TestingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TestingText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TestingText_MouseDown);
            this.TestingText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TestingText_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.TestingText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 100);
            this.panel1.TabIndex = 22;
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
            this.Exit.Location = new System.Drawing.Point(694, 1);
            this.Exit.Margin = new System.Windows.Forms.Padding(1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(32, 34);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "x";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // StartTestButton
            // 
            this.StartTestButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartTestButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartTestButton.FlatAppearance.BorderSize = 0;
            this.StartTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartTestButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTestButton.Location = new System.Drawing.Point(229, 415);
            this.StartTestButton.Name = "StartTestButton";
            this.StartTestButton.Size = new System.Drawing.Size(115, 47);
            this.StartTestButton.TabIndex = 21;
            this.StartTestButton.Text = "Запустить тестирование";
            this.StartTestButton.UseVisualStyleBackColor = false;
            this.StartTestButton.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // BD_label
            // 
            this.BD_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BD_label.Location = new System.Drawing.Point(12, 128);
            this.BD_label.Name = "BD_label";
            this.BD_label.Size = new System.Drawing.Size(159, 40);
            this.BD_label.TabIndex = 23;
            this.BD_label.Text = "Проверка соединения с базой данных";
            this.BD_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserCrLabel
            // 
            this.UserCrLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserCrLabel.Location = new System.Drawing.Point(12, 182);
            this.UserCrLabel.Name = "UserCrLabel";
            this.UserCrLabel.Size = new System.Drawing.Size(159, 40);
            this.UserCrLabel.TabIndex = 25;
            this.UserCrLabel.Text = "Тест создания учетных записей";
            this.UserCrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditLabel
            // 
            this.EditLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditLabel.Location = new System.Drawing.Point(12, 237);
            this.EditLabel.Name = "EditLabel";
            this.EditLabel.Size = new System.Drawing.Size(165, 40);
            this.EditLabel.TabIndex = 26;
            this.EditLabel.Text = "Тест редактирования учетных записей";
            this.EditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CascadeLabel
            // 
            this.CascadeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CascadeLabel.Location = new System.Drawing.Point(12, 294);
            this.CascadeLabel.Name = "CascadeLabel";
            this.CascadeLabel.Size = new System.Drawing.Size(165, 40);
            this.CascadeLabel.TabIndex = 27;
            this.CascadeLabel.Text = "Тест проверки каскадных соединений";
            this.CascadeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DelUserLabel
            // 
            this.DelUserLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelUserLabel.Location = new System.Drawing.Point(12, 350);
            this.DelUserLabel.Name = "DelUserLabel";
            this.DelUserLabel.Size = new System.Drawing.Size(159, 40);
            this.DelUserLabel.TabIndex = 28;
            this.DelUserLabel.Text = "Тест удаления учетных записей";
            this.DelUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BDconnection
            // 
            this.BDconnection.Location = new System.Drawing.Point(194, 136);
            this.BDconnection.Name = "BDconnection";
            this.BDconnection.Size = new System.Drawing.Size(173, 27);
            this.BDconnection.TabIndex = 29;
            // 
            // OK_BD_Test
            // 
            this.OK_BD_Test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
            this.OK_BD_Test.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK_BD_Test.ForeColor = System.Drawing.Color.White;
            this.OK_BD_Test.Location = new System.Drawing.Point(195, 137);
            this.OK_BD_Test.Name = "OK_BD_Test";
            this.OK_BD_Test.Size = new System.Drawing.Size(108, 25);
            this.OK_BD_Test.TabIndex = 31;
            this.OK_BD_Test.Text = "OK!";
            this.OK_BD_Test.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Failed_BD_test
            // 
            this.Failed_BD_test.BackColor = System.Drawing.Color.Red;
            this.Failed_BD_test.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.Failed_BD_test.ForeColor = System.Drawing.Color.Black;
            this.Failed_BD_test.Location = new System.Drawing.Point(194, 137);
            this.Failed_BD_test.Name = "Failed_BD_test";
            this.Failed_BD_test.Size = new System.Drawing.Size(173, 25);
            this.Failed_BD_test.TabIndex = 32;
            this.Failed_BD_test.Text = "Failed!";
            this.Failed_BD_test.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TickBD
            // 
            this.TickBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TickBD.Image = global::Authorization.Properties.Resources.tick;
            this.TickBD.Location = new System.Drawing.Point(372, 137);
            this.TickBD.Name = "TickBD";
            this.TickBD.Size = new System.Drawing.Size(25, 25);
            this.TickBD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TickBD.TabIndex = 33;
            this.TickBD.TabStop = false;
            // 
            // PB_UserCr
            // 
            this.PB_UserCr.Location = new System.Drawing.Point(194, 190);
            this.PB_UserCr.Name = "PB_UserCr";
            this.PB_UserCr.Size = new System.Drawing.Size(173, 27);
            this.PB_UserCr.TabIndex = 29;
            // 
            // OkUserTest
            // 
            this.OkUserTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
            this.OkUserTest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkUserTest.ForeColor = System.Drawing.Color.White;
            this.OkUserTest.Location = new System.Drawing.Point(196, 191);
            this.OkUserTest.Name = "OkUserTest";
            this.OkUserTest.Size = new System.Drawing.Size(108, 25);
            this.OkUserTest.TabIndex = 31;
            this.OkUserTest.Text = "OK!";
            this.OkUserTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FailedUserTest
            // 
            this.FailedUserTest.BackColor = System.Drawing.Color.Red;
            this.FailedUserTest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.FailedUserTest.ForeColor = System.Drawing.Color.Black;
            this.FailedUserTest.Location = new System.Drawing.Point(194, 191);
            this.FailedUserTest.Name = "FailedUserTest";
            this.FailedUserTest.Size = new System.Drawing.Size(173, 25);
            this.FailedUserTest.TabIndex = 32;
            this.FailedUserTest.Text = "Failed!";
            this.FailedUserTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TickUserCreation
            // 
            this.TickUserCreation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TickUserCreation.Image = global::Authorization.Properties.Resources.tick;
            this.TickUserCreation.Location = new System.Drawing.Point(372, 191);
            this.TickUserCreation.Name = "TickUserCreation";
            this.TickUserCreation.Size = new System.Drawing.Size(25, 25);
            this.TickUserCreation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TickUserCreation.TabIndex = 33;
            this.TickUserCreation.TabStop = false;
            // 
            // PBEditUser
            // 
            this.PBEditUser.Location = new System.Drawing.Point(194, 246);
            this.PBEditUser.Name = "PBEditUser";
            this.PBEditUser.Size = new System.Drawing.Size(173, 27);
            this.PBEditUser.TabIndex = 29;
            // 
            // OkEditTest
            // 
            this.OkEditTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
            this.OkEditTest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkEditTest.ForeColor = System.Drawing.Color.White;
            this.OkEditTest.Location = new System.Drawing.Point(196, 247);
            this.OkEditTest.Name = "OkEditTest";
            this.OkEditTest.Size = new System.Drawing.Size(108, 25);
            this.OkEditTest.TabIndex = 31;
            this.OkEditTest.Text = "OK!";
            this.OkEditTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FailedEditTest
            // 
            this.FailedEditTest.BackColor = System.Drawing.Color.Red;
            this.FailedEditTest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.FailedEditTest.ForeColor = System.Drawing.Color.Black;
            this.FailedEditTest.Location = new System.Drawing.Point(194, 247);
            this.FailedEditTest.Name = "FailedEditTest";
            this.FailedEditTest.Size = new System.Drawing.Size(173, 25);
            this.FailedEditTest.TabIndex = 32;
            this.FailedEditTest.Text = "Failed!";
            this.FailedEditTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TickEditUser
            // 
            this.TickEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TickEditUser.Image = global::Authorization.Properties.Resources.tick;
            this.TickEditUser.Location = new System.Drawing.Point(372, 247);
            this.TickEditUser.Name = "TickEditUser";
            this.TickEditUser.Size = new System.Drawing.Size(25, 25);
            this.TickEditUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TickEditUser.TabIndex = 33;
            this.TickEditUser.TabStop = false;
            // 
            // TickCascade
            // 
            this.TickCascade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TickCascade.Image = global::Authorization.Properties.Resources.tick;
            this.TickCascade.Location = new System.Drawing.Point(372, 303);
            this.TickCascade.Name = "TickCascade";
            this.TickCascade.Size = new System.Drawing.Size(25, 25);
            this.TickCascade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TickCascade.TabIndex = 33;
            this.TickCascade.TabStop = false;
            // 
            // PBCascade
            // 
            this.PBCascade.Location = new System.Drawing.Point(194, 302);
            this.PBCascade.Name = "PBCascade";
            this.PBCascade.Size = new System.Drawing.Size(173, 27);
            this.PBCascade.TabIndex = 29;
            // 
            // OkCascadeTest
            // 
            this.OkCascadeTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
            this.OkCascadeTest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkCascadeTest.ForeColor = System.Drawing.Color.White;
            this.OkCascadeTest.Location = new System.Drawing.Point(196, 303);
            this.OkCascadeTest.Name = "OkCascadeTest";
            this.OkCascadeTest.Size = new System.Drawing.Size(108, 25);
            this.OkCascadeTest.TabIndex = 31;
            this.OkCascadeTest.Text = "OK!";
            this.OkCascadeTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FailedCascadeTest
            // 
            this.FailedCascadeTest.BackColor = System.Drawing.Color.Red;
            this.FailedCascadeTest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.FailedCascadeTest.ForeColor = System.Drawing.Color.Black;
            this.FailedCascadeTest.Location = new System.Drawing.Point(194, 303);
            this.FailedCascadeTest.Name = "FailedCascadeTest";
            this.FailedCascadeTest.Size = new System.Drawing.Size(173, 25);
            this.FailedCascadeTest.TabIndex = 32;
            this.FailedCascadeTest.Text = "Failed!";
            this.FailedCascadeTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TickDelUser
            // 
            this.TickDelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TickDelUser.Image = global::Authorization.Properties.Resources.tick;
            this.TickDelUser.Location = new System.Drawing.Point(372, 357);
            this.TickDelUser.Name = "TickDelUser";
            this.TickDelUser.Size = new System.Drawing.Size(25, 25);
            this.TickDelUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TickDelUser.TabIndex = 33;
            this.TickDelUser.TabStop = false;
            // 
            // PBDelUser
            // 
            this.PBDelUser.Location = new System.Drawing.Point(194, 357);
            this.PBDelUser.Name = "PBDelUser";
            this.PBDelUser.Size = new System.Drawing.Size(173, 27);
            this.PBDelUser.TabIndex = 29;
            // 
            // OkDelUserTest
            // 
            this.OkDelUserTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
            this.OkDelUserTest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkDelUserTest.ForeColor = System.Drawing.Color.White;
            this.OkDelUserTest.Location = new System.Drawing.Point(196, 358);
            this.OkDelUserTest.Name = "OkDelUserTest";
            this.OkDelUserTest.Size = new System.Drawing.Size(108, 25);
            this.OkDelUserTest.TabIndex = 31;
            this.OkDelUserTest.Text = "OK!";
            this.OkDelUserTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FailedDelUserTest
            // 
            this.FailedDelUserTest.BackColor = System.Drawing.Color.Red;
            this.FailedDelUserTest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.FailedDelUserTest.ForeColor = System.Drawing.Color.Black;
            this.FailedDelUserTest.Location = new System.Drawing.Point(194, 358);
            this.FailedDelUserTest.Name = "FailedDelUserTest";
            this.FailedDelUserTest.Size = new System.Drawing.Size(173, 25);
            this.FailedDelUserTest.TabIndex = 32;
            this.FailedDelUserTest.Text = "Failed!";
            this.FailedDelUserTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GBCrossTests
            // 
            this.GBCrossTests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GBCrossTests.Controls.Add(this.DeleteField);
            this.GBCrossTests.Controls.Add(this.label2);
            this.GBCrossTests.Controls.Add(this.label1);
            this.GBCrossTests.Controls.Add(this.CascadeAdminField);
            this.GBCrossTests.Controls.Add(this.CascadeUserField);
            this.GBCrossTests.Controls.Add(this.ChangeLoginField);
            this.GBCrossTests.Controls.Add(this.UserField);
            this.GBCrossTests.Controls.Add(this.versionField);
            this.GBCrossTests.Controls.Add(this.statusLabel);
            this.GBCrossTests.Controls.Add(this.loginLabel);
            this.GBCrossTests.Controls.Add(this.surnameLabel);
            this.GBCrossTests.Controls.Add(this.nameLabel);
            this.GBCrossTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBCrossTests.ForeColor = System.Drawing.Color.Black;
            this.GBCrossTests.Location = new System.Drawing.Point(420, 106);
            this.GBCrossTests.Name = "GBCrossTests";
            this.GBCrossTests.Size = new System.Drawing.Size(295, 284);
            this.GBCrossTests.TabIndex = 34;
            this.GBCrossTests.TabStop = false;
            this.GBCrossTests.Text = "Тестовая информация:";
            // 
            // DeleteField
            // 
            this.DeleteField.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DeleteField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeleteField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteField.Font = new System.Drawing.Font("Times New Roman", 13.5F);
            this.DeleteField.ForeColor = System.Drawing.Color.Red;
            this.DeleteField.Location = new System.Drawing.Point(127, 256);
            this.DeleteField.Name = "DeleteField";
            this.DeleteField.Size = new System.Drawing.Size(160, 21);
            this.DeleteField.TabIndex = 25;
            this.DeleteField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Поиск УЗ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Связь с admins:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CascadeAdminField
            // 
            this.CascadeAdminField.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CascadeAdminField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CascadeAdminField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CascadeAdminField.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.CascadeAdminField.ForeColor = System.Drawing.Color.DarkOrchid;
            this.CascadeAdminField.Location = new System.Drawing.Point(127, 219);
            this.CascadeAdminField.Name = "CascadeAdminField";
            this.CascadeAdminField.Size = new System.Drawing.Size(160, 20);
            this.CascadeAdminField.TabIndex = 22;
            this.CascadeAdminField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CascadeUserField
            // 
            this.CascadeUserField.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CascadeUserField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CascadeUserField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CascadeUserField.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.CascadeUserField.ForeColor = System.Drawing.Color.Teal;
            this.CascadeUserField.Location = new System.Drawing.Point(127, 190);
            this.CascadeUserField.Name = "CascadeUserField";
            this.CascadeUserField.Size = new System.Drawing.Size(160, 20);
            this.CascadeUserField.TabIndex = 22;
            this.CascadeUserField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChangeLoginField
            // 
            this.ChangeLoginField.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ChangeLoginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangeLoginField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeLoginField.Font = new System.Drawing.Font("Times New Roman", 12.5F);
            this.ChangeLoginField.ForeColor = System.Drawing.Color.Blue;
            this.ChangeLoginField.Location = new System.Drawing.Point(127, 143);
            this.ChangeLoginField.Name = "ChangeLoginField";
            this.ChangeLoginField.Size = new System.Drawing.Size(160, 20);
            this.ChangeLoginField.TabIndex = 22;
            this.ChangeLoginField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserField
            // 
            this.UserField.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.UserField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserField.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.UserField.ForeColor = System.Drawing.Color.Green;
            this.UserField.Location = new System.Drawing.Point(127, 88);
            this.UserField.Name = "UserField";
            this.UserField.Size = new System.Drawing.Size(160, 20);
            this.UserField.TabIndex = 22;
            this.UserField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // versionField
            // 
            this.versionField.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.versionField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.versionField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.versionField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.versionField.ForeColor = System.Drawing.Color.Teal;
            this.versionField.Location = new System.Drawing.Point(127, 34);
            this.versionField.Name = "versionField";
            this.versionField.Size = new System.Drawing.Size(160, 22);
            this.versionField.TabIndex = 22;
            this.versionField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.Color.Black;
            this.statusLabel.Location = new System.Drawing.Point(1, 174);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(120, 51);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "Изменение в таблице users:";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.Black;
            this.loginLabel.Location = new System.Drawing.Point(1, 136);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(120, 32);
            this.loginLabel.TabIndex = 16;
            this.loginLabel.Text = "УЗ изменена на:";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // surnameLabel
            // 
            this.surnameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.ForeColor = System.Drawing.Color.Black;
            this.surnameLabel.Location = new System.Drawing.Point(1, 82);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(100, 32);
            this.surnameLabel.TabIndex = 16;
            this.surnameLabel.Text = "Создана УЗ:";
            this.surnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(1, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 32);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Версия БД:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Italic);
            this.TypeLabel.ForeColor = System.Drawing.Color.Black;
            this.TypeLabel.Location = new System.Drawing.Point(416, 423);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(181, 32);
            this.TypeLabel.TabIndex = 35;
            this.TypeLabel.Text = "Тип тестирования:";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CrossLabel
            // 
            this.CrossLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic);
            this.CrossLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.CrossLabel.Location = new System.Drawing.Point(574, 423);
            this.CrossLabel.Name = "CrossLabel";
            this.CrossLabel.Size = new System.Drawing.Size(145, 32);
            this.CrossLabel.TabIndex = 36;
            this.CrossLabel.Text = "Сквозное";
            this.CrossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeTypeButton
            // 
            this.ChangeTypeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChangeTypeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeTypeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChangeTypeButton.FlatAppearance.BorderSize = 0;
            this.ChangeTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeTypeButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeTypeButton.Location = new System.Drawing.Point(33, 415);
            this.ChangeTypeButton.Name = "ChangeTypeButton";
            this.ChangeTypeButton.Size = new System.Drawing.Size(115, 47);
            this.ChangeTypeButton.TabIndex = 22;
            this.ChangeTypeButton.Text = "Поменять тип тестирования";
            this.ChangeTypeButton.UseVisualStyleBackColor = false;
            this.ChangeTypeButton.Click += new System.EventHandler(this.ChangeTypeButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(142, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 38;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(139, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 32);
            this.label4.TabIndex = 37;
            this.label4.Text = "label4";
            // 
            // IDStartButton
            // 
            this.IDStartButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IDStartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IDStartButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.IDStartButton.FlatAppearance.BorderSize = 0;
            this.IDStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IDStartButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDStartButton.Location = new System.Drawing.Point(140, 46);
            this.IDStartButton.Name = "IDStartButton";
            this.IDStartButton.Size = new System.Drawing.Size(107, 32);
            this.IDStartButton.TabIndex = 6;
            this.IDStartButton.Text = "Запуск";
            this.IDStartButton.UseVisualStyleBackColor = false;
            // 
            // IDTestLabel
            // 
            this.IDTestLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.IDTestLabel.ForeColor = System.Drawing.Color.Black;
            this.IDTestLabel.Location = new System.Drawing.Point(6, 38);
            this.IDTestLabel.Name = "IDTestLabel";
            this.IDTestLabel.Size = new System.Drawing.Size(113, 47);
            this.IDTestLabel.TabIndex = 36;
            this.IDTestLabel.Text = "Тест проверки ID модулей";
            this.IDTestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(144, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 32);
            this.label6.TabIndex = 41;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(141, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 32);
            this.label5.TabIndex = 40;
            this.label5.Text = "label5";
            // 
            // SpellingStartButton
            // 
            this.SpellingStartButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SpellingStartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpellingStartButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.SpellingStartButton.FlatAppearance.BorderSize = 0;
            this.SpellingStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SpellingStartButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpellingStartButton.Location = new System.Drawing.Point(142, 131);
            this.SpellingStartButton.Name = "SpellingStartButton";
            this.SpellingStartButton.Size = new System.Drawing.Size(107, 32);
            this.SpellingStartButton.TabIndex = 39;
            this.SpellingStartButton.Text = "Запуск";
            this.SpellingStartButton.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 76);
            this.label7.TabIndex = 42;
            this.label7.Text = "Тест модуля коррекции ошибок ввода текста";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GBModulTest
            // 
            this.GBModulTest.Controls.Add(this.groupBox1);
            this.GBModulTest.Controls.Add(this.label7);
            this.GBModulTest.Controls.Add(this.SpellingStartButton);
            this.GBModulTest.Controls.Add(this.label5);
            this.GBModulTest.Controls.Add(this.label6);
            this.GBModulTest.Controls.Add(this.IDTestLabel);
            this.GBModulTest.Controls.Add(this.IDStartButton);
            this.GBModulTest.Controls.Add(this.label4);
            this.GBModulTest.Controls.Add(this.label3);
            this.GBModulTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBModulTest.Location = new System.Drawing.Point(12, 106);
            this.GBModulTest.Name = "GBModulTest";
            this.GBModulTest.Size = new System.Drawing.Size(703, 284);
            this.GBModulTest.TabIndex = 38;
            this.GBModulTest.TabStop = false;
            this.GBModulTest.Text = "Модульные тесты";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.FindInfoButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(285, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 100);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.textBox3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.textBox3.Location = new System.Drawing.Point(225, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 22);
            this.textBox3.TabIndex = 48;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 24);
            this.label9.TabIndex = 45;
            this.label9.Text = "Последний admin ID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.textBox2.ForeColor = System.Drawing.Color.Teal;
            this.textBox2.Location = new System.Drawing.Point(174, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 44;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FindInfoButton
            // 
            this.FindInfoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FindInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindInfoButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.FindInfoButton.FlatAppearance.BorderSize = 0;
            this.FindInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FindInfoButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindInfoButton.Location = new System.Drawing.Point(232, 26);
            this.FindInfoButton.Name = "FindInfoButton";
            this.FindInfoButton.Size = new System.Drawing.Size(103, 30);
            this.FindInfoButton.TabIndex = 47;
            this.FindInfoButton.Text = "Поиск";
            this.FindInfoButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.textBox1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.textBox1.Location = new System.Drawing.Point(174, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 43;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(311, 24);
            this.label10.TabIndex = 46;
            this.label10.Text = "Поиск информации по user ID:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 24);
            this.label8.TabIndex = 45;
            this.label8.Text = "Последний user ID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.ForeColor = System.Drawing.Color.Teal;
            this.textBox4.Location = new System.Drawing.Point(354, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(47, 25);
            this.textBox4.TabIndex = 49;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(727, 486);
            this.Controls.Add(this.GBModulTest);
            this.Controls.Add(this.CrossLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.GBCrossTests);
            this.Controls.Add(this.TickDelUser);
            this.Controls.Add(this.TickCascade);
            this.Controls.Add(this.TickEditUser);
            this.Controls.Add(this.TickUserCreation);
            this.Controls.Add(this.TickBD);
            this.Controls.Add(this.FailedDelUserTest);
            this.Controls.Add(this.OkDelUserTest);
            this.Controls.Add(this.FailedCascadeTest);
            this.Controls.Add(this.OkCascadeTest);
            this.Controls.Add(this.FailedEditTest);
            this.Controls.Add(this.OkEditTest);
            this.Controls.Add(this.PBDelUser);
            this.Controls.Add(this.FailedUserTest);
            this.Controls.Add(this.PBCascade);
            this.Controls.Add(this.OkUserTest);
            this.Controls.Add(this.PBEditUser);
            this.Controls.Add(this.Failed_BD_test);
            this.Controls.Add(this.PB_UserCr);
            this.Controls.Add(this.OK_BD_Test);
            this.Controls.Add(this.BDconnection);
            this.Controls.Add(this.DelUserLabel);
            this.Controls.Add(this.CascadeLabel);
            this.Controls.Add(this.EditLabel);
            this.Controls.Add(this.UserCrLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BD_label);
            this.Controls.Add(this.ChangeTypeButton);
            this.Controls.Add(this.StartTestButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestingForm";
            this.Load += new System.EventHandler(this.TestingForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TickBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickUserCreation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickEditUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickCascade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickDelUser)).EndInit();
            this.GBCrossTests.ResumeLayout(false);
            this.GBCrossTests.PerformLayout();
            this.GBModulTest.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TestingText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button StartTestButton;
        private System.Windows.Forms.Label BD_label;
        private System.Windows.Forms.Label UserCrLabel;
        private System.Windows.Forms.Label EditLabel;
        private System.Windows.Forms.Label CascadeLabel;
        private System.Windows.Forms.Label DelUserLabel;
        private System.Windows.Forms.ProgressBar BDconnection;
        private System.Windows.Forms.Label OK_BD_Test;
        private System.Windows.Forms.Label Failed_BD_test;
        private System.Windows.Forms.PictureBox TickBD;
        private System.Windows.Forms.ProgressBar PB_UserCr;
        private System.Windows.Forms.Label OkUserTest;
        private System.Windows.Forms.Label FailedUserTest;
        private System.Windows.Forms.PictureBox TickUserCreation;
        private System.Windows.Forms.ProgressBar PBEditUser;
        private System.Windows.Forms.Label OkEditTest;
        private System.Windows.Forms.Label FailedEditTest;
        private System.Windows.Forms.PictureBox TickEditUser;
        private System.Windows.Forms.PictureBox TickCascade;
        private System.Windows.Forms.ProgressBar PBCascade;
        private System.Windows.Forms.Label OkCascadeTest;
        private System.Windows.Forms.Label FailedCascadeTest;
        private System.Windows.Forms.PictureBox TickDelUser;
        private System.Windows.Forms.ProgressBar PBDelUser;
        private System.Windows.Forms.Label OkDelUserTest;
        private System.Windows.Forms.Label FailedDelUserTest;
        private System.Windows.Forms.GroupBox GBCrossTests;
        private System.Windows.Forms.TextBox CascadeUserField;
        private System.Windows.Forms.TextBox ChangeLoginField;
        private System.Windows.Forms.TextBox UserField;
        private System.Windows.Forms.TextBox versionField;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CascadeAdminField;
        private System.Windows.Forms.TextBox DeleteField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label CrossLabel;
        private System.Windows.Forms.Button ChangeTypeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button IDStartButton;
        private System.Windows.Forms.Label IDTestLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SpellingStartButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GBModulTest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button FindInfoButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}