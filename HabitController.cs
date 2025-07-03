using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using Example.Model;

namespace Example.Controller
{
    public class HabitController
    {
        private string connectionString = "your_connection_string_here";
        public List<Habit> Habits { get; private set; } = new List<Habit>();
        public event EventHandler OnHabitsUpdated;

        public void Add(Habit habit, int userId)
        {
            string query = "INSERT INTO Habits (Name, Goal, Days, Reminder, Description, UserId) VALUES (@Name, @Goal, @Days, @Reminder, @Description, @UserId)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", habit.Name);
                command.Parameters.AddWithValue("@Goal", habit.Goal);
                command.Parameters.AddWithValue("@Days", habit.Days);
                command.Parameters.AddWithValue("@Reminder", habit.Reminder);
                command.Parameters.AddWithValue("@Description", habit.Description);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                command.ExecuteNonQuery();
            }

            LoadHabits();
        }

        public void LoadHabits()
        {
            Habits.Clear();
            string query = "SELECT * FROM Habits";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Habits.Add(new Habit
                    {
                        Name = reader["Name"].ToString(),
                        Goal = reader["Goal"].ToString(),
                        Days = reader["Days"].ToString(),
                        Reminder = reader["Reminder"].ToString(),
                        Description = reader["Description"].ToString(),
                        UserId = Convert.ToInt32(reader["UserId"])
                    });
                }
            }

            OnHabitsUpdated?.Invoke(this, EventArgs.Empty);
        }

        public void Remove(string name)
        {
            string query = "DELETE FROM Habits WHERE Name = @Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);

                connection.Open();
                command.ExecuteNonQuery();
            }

            LoadHabits();
        }
    }
}
