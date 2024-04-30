using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authorization
{
    public partial class RegForm : Form
    {
        Point NP;
        int lastID;

        public RegForm()
        {
            InitializeComponent();
            NameField.ForeColor = Color.Gray; NameField.Text = "Введите имя";
            SurnameField.ForeColor = Color.Gray; SurnameField.Text = "Введите фамилию";
            LoginField.ForeColor = Color.Gray; LoginField.Text = "Введите ваш логин";
            PasswordField.ForeColor = Color.Gray; PasswordField.Text = "Введите пароль"; PasswordField.UseSystemPasswordChar = false;
            RetPassField.ForeColor = Color.Gray; RetPassField.Text = "Повторите пароль"; RetPassField.UseSystemPasswordChar = false;
            label1.Select();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Close();
        }

        private void RegistrationText_MouseDown(object sender, MouseEventArgs e)
        {
            NP = new Point(e.X, e.Y);
        }

        private void RegistrationText_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - NP.X;
                this.Top += e.Y - NP.Y;
            }
        }

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите имя") { NameField.Text = ""; NameField.ForeColor = Color.Black; }
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (NameField.Text == "") { NameField.Text = "Введите имя"; NameField.ForeColor = Color.Gray; }
        }

        private void NameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) // Запрещаем ввод символов, отличных от букв и управляющих символов
            {
                e.Handled = true;
            }
        }

        private void SurnameField_Enter(object sender, EventArgs e)
        {
            if (SurnameField.Text == "Введите фамилию") { SurnameField.Text = ""; SurnameField.ForeColor = Color.Black; }
        }

        private void SurnameField_Leave(object sender, EventArgs e)
        {
            if (SurnameField.Text == "") { SurnameField.Text = "Введите фамилию"; SurnameField.ForeColor = Color.Gray; }
        }

        private void SurnameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) // Запрещаем ввод символов, отличных от букв и управляющих символов
            {
                e.Handled = true;
            }
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите ваш логин") { LoginField.Text = ""; LoginField.ForeColor = Color.Black; }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "") { LoginField.Text = "Введите ваш логин"; LoginField.ForeColor = Color.Gray; }
        }

        private void LoginField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) // Запрещаем ввод символов, отличных от букв, цифр и управляющих символов
            {
                e.Handled = true;
            }
        }
        
        private void PasswordField_Enter(object sender, EventArgs e)
        {
            if (PasswordField.Text == "Введите пароль") { PasswordField.Text = ""; PasswordField.ForeColor = Color.Black; PasswordField.UseSystemPasswordChar = true; }
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (PasswordField.Text == "") { PasswordField.Text = "Введите пароль"; PasswordField.ForeColor = Color.Gray; PasswordField.UseSystemPasswordChar = false; }
        }

        private void RetPassField_Enter(object sender, EventArgs e)
        {
            if (RetPassField.Text == "Повторите пароль") { RetPassField.Text = ""; RetPassField.ForeColor = Color.Black; RetPassField.UseSystemPasswordChar = true; }
        }

        private void RetPassField_Leave(object sender, EventArgs e)
        {
            if (RetPassField.Text == "") { RetPassField.Text = "Повторите пароль"; RetPassField.ForeColor = Color.Gray; RetPassField.UseSystemPasswordChar = false; }
        }
        
        private void Registration_Click(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите имя" || SurnameField.Text == "Введите фамилию" || LoginField.Text == "Введите ваш логин" || PasswordField.Text == "Введите пароль" || RetPassField.Text == "Повторите пароль")
            { MessageBox.Show("Заполните все поля"); return; }

            if (PasswordField.Text != RetPassField.Text)
            { MessageBox.Show("Пароли не совпадают"); return; }

            if (isUserExists()) return;
            CheckID();

            DataBase db = new DataBase();
            SqlCommand command = new SqlCommand("INSERT INTO users (id, name, surname, login, pass) VALUES (@id, @name, @surname, @login, @pass)", db.GetConnection());
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = lastID + 1;
            command.Parameters.Add("@login", SqlDbType.NVarChar).Value = LoginField.Text;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = PassHash.PWhash(PasswordField.Text);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = NameField.Text;
            command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = SurnameField.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1) MessageBox.Show("Учетная запись создана успешно");
            else MessageBox.Show("Ошибка создания учетной записи");
                        
            db.CloseConnection();
            this.Close();
            RegForm form = new RegForm();
            form.Show();
        }

        public Boolean isUserExists()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * from users WHERE login = @UL", db.GetConnection());
            command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = LoginField.Text;            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, введите иной логин");
                LoginField.Select();
                //LoginField.SelectionStart = 0;
                //LoginField.SelectionLength = LoginField.Text.Length;
                return true;                
            }
            else return false;            
        }

        private int CheckID()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT id from users " +
                                               "ORDER BY id DESC", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            lastID = Convert.ToInt32(table.Rows[0]["id"].ToString());
            return lastID;
        }
    }
}
