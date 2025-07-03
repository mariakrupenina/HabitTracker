//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Drawing;
//using System.Windows.Forms;

//namespace Example
//{
//    public partial class RegisterForm : Form
//    {
//        public RegisterForm()
//        {
//            InitializeComponent();

//            userNameField.Text = "Введите имя";
//            userNameField.ForeColor = Color.Gray;
//            userSurnameField.Text = "Введите фамилию";
//            userSurnameField.ForeColor = Color.Gray;
//        }

//        private void closeButton_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }

//        // Чтобы окошко авторизации можно было перетаскивать
//        Point lastPoint;
//        private void panel1_MouseMove(object sender, MouseEventArgs e)
//        {
//            if (e.Button == MouseButtons.Left)
//            {
//                this.Left += e.X - lastPoint.X;
//                this.Top += e.Y - lastPoint.Y;
//            }
//        }

//        private void panel1_MouseDown(object sender, MouseEventArgs e)
//        {
//            lastPoint = new Point(e.X, e.Y);
//        }

//        private void userNameField_Enter(object sender, EventArgs e)
//        {
//            if (userNameField.Text == "Введите имя")
//            {
//                userNameField.Text = "";
//                userNameField.ForeColor = Color.Black;
               

//            }
//        }

//        private void userNameField_Leave(object sender, EventArgs e)
//        {
//            if (string.IsNullOrWhiteSpace(userNameField.Text))
//            {
//                userNameField.Text = "Введите имя";
//                userNameField.ForeColor = Color.Gray;
//            }
//        }

//        private void userSurnameField_Enter(object sender, EventArgs e)
//        {
//            if (userSurnameField.Text == "Введите фамилию")
//            {
//                userSurnameField.Text = "";
//                userSurnameField.ForeColor = Color.Black;
//            }
//        }

//        private void userSurnameField_Leave(object sender, EventArgs e)
//        {
//            if (string.IsNullOrWhiteSpace(userSurnameField.Text))
//            {
//                userSurnameField.Text = "Введите фамилию";
//                userSurnameField.ForeColor = Color.Gray;
//            }
//        }

//        private void buttonRegister_Click(object sender, EventArgs e)
//        {
//            if (userNameField.Text == "Введите имя")
//            {
//                MessageBox.Show("Введите имя");
//                return;
//            }



//            if (isUserExists()) return;

//            DB db = new DB();
//            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)", db.getConnection());

//            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
//            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
//            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
//            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

//            db.openConnecton();

//            if (command.ExecuteNonQuery() == 1)
//                MessageBox.Show("Аккаунт был создан");
//            else
//                MessageBox.Show("Аккаунт не был создан");
//            db.closeConnecton();
//        }

//        public Boolean isUserExists()
//        {
//            DB db = new DB();
//            DataTable table = new DataTable();
//            MySqlDataAdapter adapter = new MySqlDataAdapter();
//            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection()); // @uL - заглушка для безопасности
//            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
//            adapter.SelectCommand = command;
//            adapter.Fill(table); // трансформируем данные в таблицу

//            if (table.Rows.Count > 0)
//            {
//                MessageBox.Show("Такой логин уже есть, введите другой");
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        private void registerLabel_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            LoginForm loginForm = new LoginForm();
//            loginForm.Show();
//        }
//    }
//}
