using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public RegForm()
        {
            InitializeComponent();
            NameField.ForeColor = Color.Gray; NameField.Text = "Введите имя";
            SurnameField.ForeColor = Color.Gray; SurnameField.Text = "Введите фамилию";
            LoginField.ForeColor = Color.Gray; LoginField.Text = "Введите ваш логин";
            PasswordField.ForeColor = Color.Gray; PasswordField.Text = "Введите пароль";
            RetPassField.ForeColor = Color.Gray; RetPassField.Text = "Повторите пароль";
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
            if (PasswordField.Text == "Введите пароль") { PasswordField.Text = ""; PasswordField.ForeColor = Color.Black; }
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (PasswordField.Text == "") { PasswordField.Text = "Введите пароль"; PasswordField.ForeColor = Color.Gray; }
        }

        private void RetPassField_Enter(object sender, EventArgs e)
        {
            if (RetPassField.Text == "Повторите пароль") { RetPassField.Text = ""; RetPassField.ForeColor = Color.Black; }
        }

        private void RetPassField_Leave(object sender, EventArgs e)
        {
            if (RetPassField.Text == "") { RetPassField.Text = "Повторите пароль"; RetPassField.ForeColor = Color.Gray; }
        }
    }
}
