//using Example.Controller;
//using System;
//using System.Data;
//using System.Windows.Forms;
//using MySql.Data.MySqlClient;

//namespace Example
//{
//    public partial class LoginForm : Form
//    {
//        private int userId; // Переменная для хранения userId

//        public LoginForm()
//        {
//            InitializeComponent();
//        }

//        // Метод для проверки аутентификации
//        private void AuthenticateUser()
//        {
//            string loginUser = loginField.Text;
//            string passUser = passField.Text;

//            DB db = new DB();
//            DataTable table = new DataTable();
//            MySqlDataAdapter adapter = new MySqlDataAdapter();
//            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
//            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;

//            adapter.SelectCommand = command;
//            adapter.Fill(table);

//            if (table.Rows.Count > 0)
//            {
//                string storedHash = table.Rows[0]["pass"].ToString();
//                if (BCrypt.Net.BCrypt.Verify(passUser, storedHash))
//                {
//                    userId = Convert.ToInt32(table.Rows[0]["id"]); // Получаем userId

//                    this.Hide();
//                    WelcomeScreenForm welcomeScreenForm = new WelcomeScreenForm(userId); // Передаем userId в конструктор WelcomeScreenForm
//                    welcomeScreenForm.Show();
//                }
//                else
//                {
//                    MessageBox.Show("Неверный пароль.");
//                }
//            }
//            else
//            {
//                MessageBox.Show("Пользователь не найден.");
//            }
//        }

//        private void buttonLogin_Click(object sender, EventArgs e)
//        {
//            AuthenticateUser();
//        }

//        private void registerLabel_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            RegisterForm registerForm = new RegisterForm();
//            registerForm.Show();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            //this.passField = new Size(this.passField.Size.Width, 64);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;

        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        //чтобы окошко авторизации можно было перетаскивать
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}

