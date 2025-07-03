using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Habit
    {
        public string Name { get; set; }
        public string Goal { get; set; }
        public string Days { get; set; }
        public string Reminder { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; } // Поле для отслеживания выполнения
        public List<bool> CompletionHistory { get; internal set; }
        public int UserId { get; set; }
    }
}
