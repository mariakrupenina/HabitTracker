using System;
using System.Drawing;
using System.Windows.Forms;
using Example.Controller;
using Example.Forms;
using Example.Model;

namespace Example
{
    public partial class MainScreenForm : Form
    {
        private HabitController habitController;
        private int userId;

        public MainScreenForm(int userId)
        {
            InitializeComponent();
            habitController = new HabitController();
            habitController.OnHabitsUpdated += HabitControllerOnHabitsUpdated;
            this.userId = userId;
            RefreshHabitsList();
        }

        private void HabitControllerOnHabitsUpdated(object sender, EventArgs e)
        {
            RefreshHabitsList();
        }

        private void RefreshHabitsList()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var habit in habitController.Habits)
            {
                var panel = CreateHabitPanel(habit);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private Panel CreateHabitPanel(Habit habit)
        {
            var panel = new Panel { Width = 760, Height = 50 };

            var label = new Label { Text = habit.Name, AutoSize = true, Location = new Point(10, 15) };
            panel.Controls.Add(label);

            int numberCheak = string.IsNullOrEmpty(habit.Days) ? 21 : Convert.ToInt32(habit.Days);

            for (int i = 0; i < numberCheak; i++)
            {
                var button = new Button
                {
                    Size = new Size(30, 30),
                    Location = new Point(150 + i * 40, 10),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Tag = false
                };
                button.BackgroundImage = Properties.Resources.cross;
                button.Click += (s, e) =>
                {
                    var btn = s as Button;
                    bool state = (bool)btn.Tag;
                    btn.BackgroundImage = state ? Properties.Resources.cross : Properties.Resources.check;
                    btn.Tag = !state;
                };
                panel.Controls.Add(button);
            }

            return panel;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteForm deleteHabit = new DeleteForm(habitController, userId); // Передаем userId
            deleteHabit.FormClosed += HabitFormClosed;
            deleteHabit.ShowDialog();
            RefreshHabitsList();
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FollowHabbit followHabbit = new FollowHabbit();
            followHabbit.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenCreatHabitScreen();
        }

        private void addHabitButton_Click(object sender, EventArgs e)
        {
            OpenCreatHabitScreen();
        }

        private void OpenCreatHabitScreen()
        {
            this.Hide();
            CreatHabitScreenForm createHabitForm = new CreatHabitScreenForm(habitController, userId);
            createHabitForm.FormClosed += HabitFormClosed;
            createHabitForm.ShowDialog();
        }

        private void CreatHabitScreenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            RefreshHabitsList();
        }

        private void HabitFormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshHabitsList();
            this.Show();
        }
    }
}
