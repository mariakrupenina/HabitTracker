using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Example.Model
{
    [Serializable]
    public class Habit //создание привычки
    {
        /// <summary>
        /// 
        /// 
        /// Состав новой привычки:
        /// Название
        /// Цель
        /// Количество дней
        /// Напоминание
        /// Описание
        /// </summary>
        /// 
        //Название привычек

        [JsonInclude]
        public string Name { get; set; }

        //Цель привычки
        public string Goal { get; set; }

        //Количество дней(Релизовать проверку)
        public string Days { get; set; }

        //Описание привычки 
        public string Description { get; set; }

        //Список привычек
        public List<Habit> CreatedHabits { get; set; }

        //конструктор без параметров
        public Habit() { }

        //конструктор с параметрами
        public Habit(string name, string goal, string days, string description)
        {
            Name = name;
            Goal = goal;
            Days = days;
            Description = description;
        }

        public override string ToString()
        {
            return Name + " " + Goal;
        }
    }
}
