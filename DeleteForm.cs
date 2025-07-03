using Example.Controller;
using System;
using System.Windows.Forms;

namespace Example.Forms
{
    public partial class DeleteForm : Form
    {
        private HabitController habitController;
        private int userId;

        public DeleteForm(HabitController controller, int userId)
        {
            InitializeComponent();
            habitController = controller;
            this.userId = userId; // Принимаем userId
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            habitController.Remove(name);

            MessageBox.Show($"Привычка '{name}' удалена");
            // Закрыть текущую форму
            this.Close();
        }
    }
}
