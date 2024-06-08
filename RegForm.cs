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
    public partial class RegForm : Form     //форма регистрации
    {
        Point NP;
        int lastID;
        public int lastIDforTests;
        public string loginForTests, hashForTests;

        public RegForm()                    //действия при загрузке формы
        {
            InitializeComponent();
            NameField.ForeColor = Color.Gray; NameField.Text = "Введите имя";
            SurnameField.ForeColor = Color.Gray; SurnameField.Text = "Введите фамилию";
            LoginField.ForeColor = Color.Gray; LoginField.Text = "Введите ваш логин";
            PasswordField.ForeColor = Color.Gray; PasswordField.Text = "Введите пароль"; PasswordField.UseSystemPasswordChar = false;
            RetPassField.ForeColor = Color.Gray; RetPassField.Text = "Повторите пароль"; RetPassField.UseSystemPasswordChar = false;
            label1.Select();
        }

        private void Exit_Click(object sender, EventArgs e)     //действия при нажатии на крестик(закрытие формы)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Close();
        }

        private void RegistrationText_MouseDown(object sender, MouseEventArgs e)    //захват координат
        {
            NP = new Point(e.X, e.Y);
        }

        private void RegistrationText_MouseMove(object sender, MouseEventArgs e)    //перемещение окна формы
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - NP.X;
                this.Top += e.Y - NP.Y;
            }
        }
        //список действий при появлении и потере фокуса на соответствующих полях заполнения данных регистрации
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
            if (char.IsSeparator(e.KeyChar) && LoginField.Text.Length == 0)         // блок пробела, если введен первым символом
            {
                e.Handled = true;
                return;
            }

            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar)) // Запрещаем ввод символов,
            {                                                                                                                         // отличных от букв, цифр,
                e.Handled = true;                                                                                                     // управляющих символов, пробелов
            }

            LoginField.Text = LoginField.Text.TrimStart(new Char[] { ' ' });        // удаление пробела, если стоит перед словом            
        }

        private void LoginField_KeyUp(object sender, KeyEventArgs e)    //Разрешает добавление нижнего подчеркивания
        {
            if (ModifierKeys == Keys.Shift)         //проверка нажатой кнопки;
            {
                if (e.KeyCode == Keys.OemMinus)     //проверка нажатой кнопки;
                {
                    {                        
                        LoginField.SelectedText = "_";
                    }
                }
            }

            LoginField.Text = LoginField.Text.TrimStart(new Char[] { ' ' });    // удаление пробела, если стоит перед словом
            if (LoginField.Text.Contains("  "))                                 // удаление двойных пробелов
            {
                int a = 0;
                for (int i = 0; i < LoginField.TextLength; i++)
                {
                    if (a == 0) a = LoginField.Text.IndexOf("  ", 0) + 1;
                    LoginField.Text = LoginField.Text.Replace("  ", " ");       // заменяет два пробела - одним
                    LoginField.SelectionStart = a;                              // установка курсора в конце замененных пробелов
                }
            }

            if (LoginField.Text.Contains("__"))                                 // удаление двойных подчеркиваний
            {
                int a = 0;
                for (int i = 0; i < LoginField.TextLength; i++)
                {
                    if (a == 0) a = LoginField.Text.IndexOf("__", 0) + 1;
                    LoginField.Text = LoginField.Text.Replace("__", "_");       // заменяет два подчеркивания - одним
                    LoginField.SelectionStart = a;                              // установка курсора в конце замененных подчеркиваний
                }
            }

            if (LoginField.Text.Contains("_ "))                                 // удаление подчеркивания с пробелом
            {
                int a = 0;
                for (int i = 0; i < LoginField.TextLength; i++)
                {
                    if (a == 0) a = LoginField.Text.IndexOf("_ ", 0) + 1;
                    LoginField.Text = LoginField.Text.Replace("_ ", "_");       // заменяет на подчеркивание
                    LoginField.SelectionStart = a;                              // установка курсора в конце замененных символов
                }
            }

            if (LoginField.Text.Contains(" _"))                                 // удаление пробела с подчеркиванием
            {
                int a = 0;
                for (int i = 0; i < LoginField.TextLength; i++)
                {
                    if (a == 0) a = LoginField.Text.IndexOf(" _", 0) + 1;
                    LoginField.Text = LoginField.Text.Replace(" _", "_");       // заменяет на подчеркивание
                    LoginField.SelectionStart = a;                              // установка курсора в конце замененных символов
                }
            }
        }

        private void PasswordField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))         // блок пробела, если введен первым символом
            {
                e.Handled = true;
                return;
            }
        }

        private void RetPassField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))         // блок пробела, если введен первым символом
            {
                e.Handled = true;
                return;
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

        public Boolean isUserExists()       //проверка уже существующих пользователей на совпадение логинов
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

        public int CheckLastUserID()        //проверка последнего ID в таблице users
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

        private void Registration_Click(object sender, EventArgs e)     //действия при нажатие на кнопку регистрации
        {
            LoginField.Text = LoginField.Text.TrimEnd(new Char[] { ' ' });   // удаление пробелов, если стоит после логина
            if (NameField.Text == "Введите имя" || SurnameField.Text == "Введите фамилию" || LoginField.Text == "Введите ваш логин" || PasswordField.Text == "Введите пароль" || RetPassField.Text == "Повторите пароль")
            { MessageBox.Show("Заполните все поля"); return; }

            if (PasswordField.Text != RetPassField.Text)
            { MessageBox.Show("Пароли не совпадают"); return; }

            if (isUserExists()) return;            

            RegNewUser(NameField.Text, SurnameField.Text, LoginField.Text, PasswordField.Text);

            this.Close();
            RegForm form = new RegForm();
            form.Show();
        }

        public void RegNewUser(string firstName, string lastName, string login, string password)    //модуль регистрации пользователя в БД
        {
            CheckLastUserID(); lastIDforTests = lastID + 1;
            DataBase db = new DataBase();
            SqlCommand command = new SqlCommand("INSERT INTO users (id, name, surname, login, pass) VALUES (@id, @name, @surname, @login, @pass)", db.GetConnection());
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = lastID + 1;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = firstName;
            command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = lastName;
            command.Parameters.Add("@login", SqlDbType.NVarChar).Value = login;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = PassHash.PWhash(password);

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1) MessageBox.Show("Учетная запись создана успешно");
            else MessageBox.Show("Ошибка создания учетной записи");

            db.CloseConnection();
        }

        public void CompareForTests()   //проверка специально для тестов xunit
        {            
            Comparison();
        }

        private void Comparison()       //сравнение логинов
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT id, login from users " +
                                               "ORDER BY id DESC", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            lastIDforTests = (Int32)table.Rows[0]["id"];
            loginForTests = table.Rows[0]["login"].ToString();
        }

        public string Hash(string pass) //хэш-функция для тестов xunit
        {
            hashForTests = PassHash.PWhash(pass);
            return hashForTests.ToString();
        }
    }
}
