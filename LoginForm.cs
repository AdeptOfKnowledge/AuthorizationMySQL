using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        Point NP;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.CheckConnection();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void SignIn_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * from users WHERE login = @UL AND pass = @UP", db.GetConnection());
            command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = Login.Text;
            command.Parameters.Add("@UP", SqlDbType.NVarChar).Value = PassHash.PWhash(Password.Text);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                PortalForm portal = new PortalForm();
                portal.userLogin = Login.Text;
                portal.Show();
                this.Hide();
            }

            else MessageBox.Show("Имя пользователя или пароль не совпадают");
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegForm f = new RegForm();
            f.Show();
            this.Hide();
        }

        private void PassShow_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Password.UseSystemPasswordChar == true) { Password.UseSystemPasswordChar = false; PassShow.Visible = false;}
            }
        }

        private void PassHide_Click(object sender, EventArgs e)
        {
            if (Password.UseSystemPasswordChar == false) { Password.UseSystemPasswordChar = true; PassShow.Visible = true; }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar) && Login.Text.Length == 0)         // блок пробела, если введен первым символом
            {
                e.Handled = true;
                return;
            }

            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar)) // Запрещаем ввод символов,
            {                                                                                                                         // отличных от букв, цифр,
                e.Handled = true;                                                                                                     // управляющих символов, пробелов
            }

            Login.Text = Login.Text.TrimStart(new Char[] { ' ' });        // удаление пробела, если стоит перед словом            
        }

        private void Login_KeyUp(object sender, KeyEventArgs e)    //Разрешает добавление нижнего подчеркивания
        {
            if (ModifierKeys == Keys.Shift)         //проверка нажатой кнопки;
            {
                if (e.KeyCode == Keys.OemMinus)     //проверка нажатой кнопки;
                {
                    {
                        Login.SelectedText = "_";
                    }
                }
            }

            Login.Text = Login.Text.TrimStart(new Char[] { ' ' });    // удаление пробела, если стоит перед словом
            if (Login.Text.Contains("  "))                                 // удаление двойных пробелов
            {
                int a = 0;
                for (int i = 0; i < Login.TextLength; i++)
                {
                    if (a == 0) a = Login.Text.IndexOf("  ", 0) + 1;
                    Login.Text = Login.Text.Replace("  ", " ");       // заменяет два пробела - одним
                    Login.SelectionStart = a;                              // установка курсора в конце замененных пробелов
                }
            }

            if (Login.Text.Contains("__"))                                 // удаление двойных подчеркиваний
            {
                int a = 0;
                for (int i = 0; i < Login.TextLength; i++)
                {
                    if (a == 0) a = Login.Text.IndexOf("__", 0) + 1;
                    Login.Text = Login.Text.Replace("__", "_");       // заменяет два подчеркивания - одним
                    Login.SelectionStart = a;                              // установка курсора в конце замененных подчеркиваний
                }
            }

            if (Login.Text.Contains("_ "))                                 // удаление подчеркивания с пробелом
            {
                int a = 0;
                for (int i = 0; i < Login.TextLength; i++)
                {
                    if (a == 0) a = Login.Text.IndexOf("_ ", 0) + 1;
                    Login.Text = Login.Text.Replace("_ ", "_");       // заменяет на подчеркивание
                    Login.SelectionStart = a;                              // установка курсора в конце замененных символов
                }
            }

            if (Login.Text.Contains(" _"))                                 // удаление пробела с подчеркиванием
            {
                int a = 0;
                for (int i = 0; i < Login.TextLength; i++)
                {
                    if (a == 0) a = Login.Text.IndexOf(" _", 0) + 1;
                    Login.Text = Login.Text.Replace(" _", "_");       // заменяет на подчеркивание
                    Login.SelectionStart = a;                              // установка курсора в конце замененных символов
                }
            }
        }

        private void Tests_button_Click(object sender, EventArgs e)
        {
            TestingForm tf = new TestingForm();
            tf.Show();
            this.Hide();
        }

    }
}
