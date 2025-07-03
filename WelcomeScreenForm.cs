using Example.Controller;
using System;
using System.Windows.Forms;

namespace Example
{
    public partial class WelcomeScreenForm : Form
    {
        private int userId;

        public WelcomeScreenForm()
        {
            InitializeComponent();
        }

        public WelcomeScreenForm(int userId) : this()
        {
            this.userId = userId;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainScreenForm mainScreen = new MainScreenForm(userId);
            mainScreen.FormClosed += (s, args) => this.Close();
            mainScreen.Show();
            this.Hide();
        }

        private void WelcomeScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
