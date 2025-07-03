using System;
using System.Windows.Forms;
using Example.Controller;
using Example.Model;

namespace Example
{
    public partial class CreatHabitScreenForm : Form
    {
        private HabitController habitController;
        private int userId;

        public CreatHabitScreenForm(HabitController controller, int userId)
        {
            InitializeComponent();
            habitController = controller;
            this.userId = userId;
        }

        public CreatHabitScreenForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string habitName = name.Text;
            string habitGoal = goal.Text;
            string habitDays = days.Text;
            string habitReminder = reminder.Text;
            string habitDescription = description.Text;

            if (string.IsNullOrEmpty(habitName))
            {
                MessageBox.Show("Пожалуйста, введите название привычки.");
                return;
            }

            Habit newHabit = new Habit
            {
                Name = habitName,
                Goal = habitGoal,
                Days = habitDays,
                Reminder = habitReminder,
                Description = habitDescription
            };

            if (habitController != null)
            {
                habitController.Add(newHabit, userId);
                MessageBox.Show($"Привычка '{habitName}' добавлена");
            }
            else
            {
                MessageBox.Show("Контроллер привычек не инициализирован.");
            }

            this.Close();
        }
    }
}
