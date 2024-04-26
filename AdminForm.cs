using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Authorization
{
    public partial class AdminForm : Form
    {
        Point NP; bool but = false, sbut = false;
        public bool admPanel = true;
        public string adminLogin, id, status;        

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            adminName.Text = adminLogin;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT login from users", db.GetConnection());

            db.OpenConnection(); //Открываем соединение
            MySqlDataReader read = command.ExecuteReader(); //Считываем и извлекаем данные
            while (read.Read()) //Читаем пока есть данные
            {
                Users.Items.Add(read.GetValue(0).ToString()); //Добавляем данные в лист итем
            }
            db.CloseConnection(); //Закрываем соединение 
            Permissions();
        }

        private void Permissions()
        {
            if (!admPanel)
            {
                AdminButton.BackColor = Color.LightGray; superAdminButton.BackColor = Color.LightGray;
                superAdminButton.Enabled = false; superAdminBehindBox.Enabled = false;
                AdminButton.Enabled = false; AdminBehindBox.Enabled = false;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            PortalForm portal = new PortalForm();
            portal.userLogin = adminLogin;
            portal.Show();
            this.Close();
        }

        private void AuthorizationText_MouseDown(object sender, MouseEventArgs e)
        {
            NP = new Point(e.X, e.Y);
        }

        private void AuthorizationText_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - NP.X;
                this.Top += e.Y - NP.Y;
            }
        }

        private void AdminButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (loginField.Text != "")
            {
                if (but == false)
                {
                    AdminButton.CheckState = CheckState.Indeterminate; AdminButton.BackColor = Color.FromArgb(255, 215, 228, 242);
                    AdminButton.Checked = true; AdminButton.Enabled = false;
                    AdminButton_GiveAdmin();
                }
                but = true;
            }
            else AdminButton.CheckState = CheckState.Unchecked;
        }

        private void AdminBehindBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (loginField.Text != "")
            {
                if (but == true && e.Button == MouseButtons.Left)
                {
                    AdminButton.CheckState = CheckState.Unchecked; AdminButton.BackColor = Color.FromArgb(255, 153, 180, 209);
                    AdminButton.Enabled = true; AdminButton.Checked = false;
                    but = false;
                    AdminButton_DropAdmin();
                }
            }
        }
        private void superAdminButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (loginField.Text != "")
            {
                if (sbut == false)
                {
                    superAdminButton.CheckState = CheckState.Indeterminate; superAdminButton.BackColor = Color.FromArgb(255, 215, 228, 242);
                    superAdminButton.Checked = true; superAdminButton.Enabled = false;
                    superAdminButton_GiveSuperAdmin();
                }
                sbut = true;
            }
            else superAdminButton.CheckState = CheckState.Unchecked;
        }

        private void superAdminBehindBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (loginField.Text != "")
            {
                if (sbut == true && e.Button == MouseButtons.Left)
                {
                    superAdminButton.CheckState = CheckState.Unchecked; superAdminButton.BackColor = Color.FromArgb(255, 153, 180, 209);
                    superAdminButton.Enabled = true; superAdminButton.Checked = false;
                    sbut = false;
                    superAdminButton_DropAdmin();
                }
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Close();
        }

        private void Users_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (Users.SelectedItem != null) 
            {
                loginField.Text = Users.SelectedItem.ToString();

                DataBase db = new DataBase();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT u.name as name, u.surname surname, a.permissions adm " +
                                                        "from users u " +
                                                        "LEFT JOIN admins a on a.user_login = u.login " +
                                                        "where u.login = @UL ", db.GetConnection());

                command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = loginField.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                nameField.Text = table.Rows[0]["name"].ToString();
                surnameField.Text = table.Rows[0]["surname"].ToString();
                statusField.Text = table.Rows[0]["adm"].ToString();

                StatusInfo();
                Permissions();
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            Users.Items.Clear();
            AdminForm_Load(this, EventArgs.Empty);

            if (UserSearching.Text != "")
            {
                ListBox temp = new ListBox();

                for (int i = 0; i < Users.Items.Count; i++)
                {
                    string compare = Convert.ToString(Users.Items[i]);
                    if (compare.IndexOf(UserSearching.Text) >= 0) temp.Items.Add(compare);
                }
                Users.Items.Clear();
                if (temp.Items.Count > 0)
                {
                    Users.Items.AddRange(temp.Items);
                }
            }
        }

        private void UserSearching_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Users.Items.Clear();
                AdminForm_Load(this, EventArgs.Empty);

                if (UserSearching.Text != "")
                {
                    ListBox temp = new ListBox();

                    for (int i = 0; i < Users.Items.Count; i++)
                    {
                        string compare = Convert.ToString(Users.Items[i]);
                        if (compare.IndexOf(UserSearching.Text) >= 0) temp.Items.Add(compare);
                    }
                    Users.Items.Clear();
                    if (temp.Items.Count > 0)
                    {
                        Users.Items.AddRange(temp.Items);
                    }
                }                
            }
        }
        private void CheckUserID()
        {
            if (loginField.Text != "")
            {
                DataBase db = new DataBase();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT id from users WHERE login = @UL", db.GetConnection());

                command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = loginField.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                id = table.Rows[0]["id"].ToString();
            }
        }

        private void StatusCheck()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT a.permissions " +
                                                    "from users u " +
                                                    "LEFT JOIN admins a on a.user_login = u.login " +
                                                    "WHERE login = @UL", db.GetConnection());

            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = loginField.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            statusField.Text = table.Rows[0]["permissions"].ToString();
            StatusInfo();
        }

        private void StatusInfo()
        {
            if (statusField.Text == "")
            {
                statusField.Text = "user"; statusField.ForeColor = Color.Green;
                AdminButton.CheckState = CheckState.Unchecked; superAdminButton.CheckState = CheckState.Unchecked;
                AdminButton.BackColor = Color.FromArgb(255, 153, 180, 209);
                AdminButton.Enabled = true; AdminButton.Checked = false; but = false;
                superAdminButton.BackColor = Color.FromArgb(255, 153, 180, 209);
                superAdminButton.Enabled = true; superAdminButton.Checked = false; sbut = false;
            }
            if (statusField.Text == "0")
            {
                statusField.Text = "admin"; statusField.ForeColor = Color.Blue;
                AdminButton.CheckState = CheckState.Indeterminate; superAdminButton.CheckState = CheckState.Unchecked;
                AdminButton.BackColor = Color.FromArgb(255, 215, 228, 242);
                AdminButton.Checked = true; AdminButton.Enabled = false; but = true;
                superAdminButton.BackColor = Color.FromArgb(255, 153, 180, 209);
                superAdminButton.Enabled = true; superAdminButton.Checked = false; sbut = false;
                AdminBehindBox.Enabled = true;
            }
            if (statusField.Text == "1")
            {
                statusField.Text = "superadmin"; statusField.ForeColor = Color.DarkOrchid;
                AdminButton.CheckState = CheckState.Indeterminate; superAdminButton.CheckState = CheckState.Indeterminate;
                AdminButton.BackColor = Color.LightGray; //FromArgb(255, 215, 228, 242);
                AdminButton.Checked = true; AdminButton.Enabled = false; but = true;
                superAdminButton.BackColor = Color.FromArgb(255, 215, 228, 242);
                superAdminButton.Checked = true; superAdminButton.Enabled = false; sbut = true;
                AdminBehindBox.Enabled = false;
            }
        }

        private void AdminButton_GiveAdmin()
        {
            if (loginField.Text != "" || loginField.Text == "user")
            {
                CheckUserID();

                DataBase db = new DataBase();
                MySqlCommand command = new MySqlCommand("INSERT INTO admins (user_id, user_login, permissions)" +
                                                        "VALUES (@ID, @UL, 0) ", db.GetConnection());

                command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = loginField.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;

                db.OpenConnection();
                command.ExecuteReader();
                db.CloseConnection(); //Закрываем соединение                 

                StatusCheck();
            }
        }

        private void AdminButton_DropAdmin()
        {
            if (superAdminButton.CheckState != CheckState.Indeterminate)
            {
                if (loginField.Text != "")
                {
                    DataBase db = new DataBase();
                    MySqlCommand command = new MySqlCommand("DELETE FROM admins WHERE user_login = @UL", db.GetConnection());
                    command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = loginField.Text;

                    db.OpenConnection();
                    command.ExecuteReader();
                    db.CloseConnection(); //Закрываем соединение 

                    StatusCheck();
                }
            }
        }

        private void superAdminButton_GiveSuperAdmin()
        {
            if (loginField.Text != "" && statusField.Text != "superadmin")
            {
                CheckUserID();

                DataBase db = new DataBase();
                MySqlCommand command = new MySqlCommand();
                if (statusField.Text == "user")
                {
                    command = new MySqlCommand("INSERT INTO admins (user_id, user_login, permissions)" +
                                               "VALUES (@ID, @UL, 1) ", db.GetConnection());
                }
                if (statusField.Text == "admin")
                {
                    command = new MySqlCommand("UPDATE admins SET permissions = REPLACE(permissions, 0, 1) " +
                                               "where user_login = @UL ", db.GetConnection());
                }
                command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = loginField.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;

                db.OpenConnection();
                command.ExecuteReader();
                db.CloseConnection(); //Закрываем соединение                 

                StatusCheck();                
            }
        }

        private void superAdminButton_DropAdmin()
        {
            if (statusField.Text == "superadmin")
            {
                if (loginField.Text != "")
                {
                    DataBase db = new DataBase();
                    MySqlCommand command = new MySqlCommand("UPDATE admins SET permissions = REPLACE(permissions, 1, 0) " +
                                                            "where user_login = @UL ", db.GetConnection());
                    command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = loginField.Text;

                    db.OpenConnection();
                    command.ExecuteReader();
                    db.CloseConnection(); //Закрываем соединение 

                    AdminBehindBox.Enabled = true;

                    StatusCheck();
                }
            }
            else return;
        }

        private void DelUsrButton_Click(object sender, EventArgs e)
        {
            if (loginField.Text != "")
            {
                DataBase db = new DataBase();
                MySqlCommand command = new MySqlCommand("DELETE FROM users WHERE login = @UL", db.GetConnection());
                command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = loginField.Text;

                db.OpenConnection();
                command.ExecuteReader();
                db.CloseConnection(); //Закрываем соединение 

                Users.Items.Clear();
                AdminForm_Load(this, EventArgs.Empty);
            }            
        }
    }
}
