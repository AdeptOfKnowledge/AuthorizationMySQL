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
    public partial class RenameLogin : Form
    {
        public string UN; 
        Point NP;

        public RenameLogin()
        {
            InitializeComponent();
        }

        private void RenameLogin_Load(object sender, EventArgs e)
        {
            loginField.Text = UN;
            NewLogin.ForeColor = Color.Gray; NewLogin.Text = "Введите новый логин";            
        }

        private void NewLogin_Enter(object sender, EventArgs e)
        {
            if (NewLogin.Text == "Введите новый логин") { NewLogin.Text = ""; NewLogin.ForeColor = Color.Black; }
        }

        private void NewLogin_Leave(object sender, EventArgs e)
        {
            if (NewLogin.Text == "") { NewLogin.Text = "Введите новый логин"; NewLogin.ForeColor = Color.Gray; }
        }

        private void NewLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar) && NewLogin.Text.Length == 0)         // блок пробела, если введен первым символом
            {
                e.Handled = true;
                return;
            }

            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar)) // Запрещаем ввод символов,
            {                                                                                                                         // отличных от букв, цифр,
                e.Handled = true;                                                                                                     // управляющих символов, пробелов
            }

            NewLogin.Text = NewLogin.Text.TrimStart(new Char[] { ' ' });        // удаление пробела, если стоит перед словом
            NewLogin.Text.Replace("  ", " ");
        }

        private void NewLogin_KeyUp(object sender, KeyEventArgs e)    //Разрешает добавление нижнего подчеркивания
        {
            if (ModifierKeys == Keys.Shift)         //проверка нажатой кнопки;
            {
                if (e.KeyCode == Keys.OemMinus)     //проверка нажатой кнопки;
                {
                    {
                        NewLogin.SelectedText = "_";
                    }
                }
            }

            NewLogin.Text = NewLogin.Text.TrimStart(new Char[] { ' ' });    // удаление пробела, если стоит перед словом
            if (NewLogin.Text.Contains("  "))                               // удаление двойных пробелов
            {
                int a = 0;
                for (int i = 0; i < NewLogin.TextLength; i++)
                {
                    if (a == 0) a = NewLogin.Text.IndexOf("  ", 0) + 1;
                    NewLogin.Text = NewLogin.Text.Replace("  ", " ");       // заменяет два пробела - одним
                    NewLogin.SelectionStart = a;                            // установка курсора в конце замененных пробелов
                }
            }

            if (NewLogin.Text.Contains("__"))                                 // удаление двойных подчеркиваний
            {
                int a = 0;
                for (int i = 0; i < NewLogin.TextLength; i++)
                {
                    if (a == 0) a = NewLogin.Text.IndexOf("__", 0) + 1;
                    NewLogin.Text = NewLogin.Text.Replace("__", "_");       // заменяет два подчеркивания - одним
                    NewLogin.SelectionStart = a;                              // установка курсора в конце замененных подчеркиваний
                }
            }

            if (NewLogin.Text.Contains("_ "))                                 // удаление подчеркивания с пробелом
            {
                int a = 0;
                for (int i = 0; i < NewLogin.TextLength; i++)
                {
                    if (a == 0) a = NewLogin.Text.IndexOf("_ ", 0) + 1;
                    NewLogin.Text = NewLogin.Text.Replace("_ ", "_");       // заменяет на подчеркивание
                    NewLogin.SelectionStart = a;                              // установка курсора в конце замененных символов
                }
            }

            if (NewLogin.Text.Contains(" _"))                                 // удаление пробела с подчеркиванием
            {
                int a = 0;
                for (int i = 0; i < NewLogin.TextLength; i++)
                {
                    if (a == 0) a = NewLogin.Text.IndexOf(" _", 0) + 1;
                    NewLogin.Text = NewLogin.Text.Replace(" _", "_");       // заменяет на подчеркивание
                    NewLogin.SelectionStart = a;                              // установка курсора в конце замененных символов
                }
            }
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

        public Boolean isUserExists()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * from users WHERE login = @UL", db.GetConnection());
            command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = NewLogin.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, введите иной логин");
                NewLogin.Select();
                //NewLogin.SelectionStart = 0;
                //NewLogin.SelectionLength = LoginField.Text.Length;
                return true;
            }
            else return false;
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            NewLogin.Text = NewLogin.Text.TrimEnd(new Char[] { ' ' });        // удаление пробела, если стоит после логина
            if (isUserExists()) return;                                       // проверка уже существующих логинов

            if (NewLogin.Text != "" && NewLogin.Text != "Введите новый логин")
            {
                DialogResult = DialogResult.OK;
                UN = NewLogin.Text;
            }
            else
            {
                NewLogin.ForeColor = Color.Gray; NewLogin.Text = "Введите новый логин";
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
