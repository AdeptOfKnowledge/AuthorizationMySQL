using MySql.Data.MySqlClient;
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
        public string adminLogin;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            adminName.Text = adminLogin;

            DataBase db = new DataBase();            
            MySqlDataAdapter adapter = new MySqlDataAdapter();            

            MySqlCommand command = new MySqlCommand("SELECT login from users", db.GetConnection());

            adapter.SelectCommand = command;            

            /* string connectionString = @"Data Source= NCMBW832\SQLEXPRESS; Initial Catalog = kk_start; Integrated Security = SSPI; Connect Timeout = 15;" +
                     "Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"; // строка подключения
                 SqlConnection Con = new SqlConnection(connectionString); //Новое подключение
                 SqlCommand command = new SqlCommand("SELECT UserName FROM [User]", Con); //Команда выбора данных */

            db.OpenConnection(); //Открываем соединение
            MySqlDataReader read = command.ExecuteReader(); //Считываем и извлекаем данные
            while (read.Read()) //Читаем пока есть данные
            {
                Users.Items.Add(read.GetValue(0).ToString()); //Добавляем данные в лист итем
            }
            db.CloseConnection(); //Закрываем соединение 
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
            
            if (but == false) 
            {
                AdminButton.CheckState = CheckState.Indeterminate; AdminButton.BackColor = Color.FromArgb(255, 215, 228, 242);
                AdminButton.Checked = true; AdminButton.Enabled = false;
                AdminButton.ForeColor = Color.Blue; 
            }
            but = true;
        }

        private void AdminBehindBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (but == true && e.Button == MouseButtons.Left)
            {
                AdminButton.CheckState = CheckState.Unchecked; AdminButton.BackColor = Color.FromArgb(255, 153, 180, 209);
                AdminButton.Enabled = true; AdminButton.Checked = false; 
                but = false; 
            }
        }
        private void superAdminButton_MouseClick(object sender, MouseEventArgs e)
        {

            if (sbut == false)
            {
                superAdminButton.CheckState = CheckState.Indeterminate; superAdminButton.BackColor = Color.FromArgb(255, 215, 228, 242);
                superAdminButton.Checked = true; superAdminButton.Enabled = false;
            }
            sbut = true;
        }

        private void superAdminBehindBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (sbut == true && e.Button == MouseButtons.Left)
            {
                superAdminButton.CheckState = CheckState.Unchecked; superAdminButton.BackColor = Color.FromArgb(255, 153, 180, 209);
                superAdminButton.Enabled = true; superAdminButton.Checked = false;
                sbut = false;
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
                if (statusField.Text == "") { statusField.Text = "user"; statusField.ForeColor = Color.Green; }
                if (statusField.Text == "0") { statusField.Text = "admin"; statusField.ForeColor = Color.Blue; }
                if (statusField.Text == "1") { statusField.Text = "superadmin"; statusField.ForeColor = Color.DarkOrchid; }
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
    }
}
