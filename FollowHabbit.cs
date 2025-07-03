using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Example.Controller;


namespace Example
{
    public partial class FollowHabbit : Form
    {
        private HabitController habitController;

        public FollowHabbit()
        {
            InitializeComponent();
            habitController = new HabitController();
            InitializeChart();

            // Подписываемся на событие обновления привычек
            habitController.OnHabitsUpdated += HabitController_OnHabitsUpdated;
        }

        private void HabitController_OnHabitsUpdated(object sender, EventArgs e)
        {
            if (sender is HabitController controller)
            {
                var habits = controller.Habits.ToList(); // Получаем список привычек
                if (habits.Count > 0)
                {
                    LoadHabitData(habits[0]); // Загружаем данные для первой привычки (пример)
                }
            }
        }

        private void InitializeChart()
        {
            habitChart.Series.Clear();
            habitChart.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            habitChart.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "Completion",
                Color = Color.Green,
                ChartType = SeriesChartType.Line
            };
            habitChart.Series.Add(series);

            habitChart.Legends.Clear();
            habitChart.Legends.Add(new Legend("Legend"));
        }

        public void LoadHabitData(Habit habit)
        {
            habitChart.Series[0].Points.Clear();

            for (int i = 0; i < habit.CompletionHistory.Count; i++)
            {
                int value = habit.CompletionHistory[i] ? 1 : 0;

                habitChart.Series["Completion"].Points.AddXY(i + 1, value);
            }
        }

        private void FollowHabbit_Load(object sender, EventArgs e)
        {
            // Example usage
            Habit exampleHabit = new Habit
            {
                Name = "Exercise",
                CompletionHistory = new List<bool> { true, false, true, true, false, false, true }
            };

            LoadHabitData(exampleHabit);
        }

        private void habitChart_Click(object sender, EventArgs e)
        {

        }
    }


    
}
