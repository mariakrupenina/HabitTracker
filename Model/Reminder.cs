using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example.Model
{
    public class Reminder
    {
        private NotifyIcon notifyIcon;
        private Timer timer;

        public Reminder(NotifyIcon notifyIcon)
        {
            this.notifyIcon = notifyIcon;
            this.timer = new Timer();
            this.timer.Interval = 60000; // Интервал в миллисекундах
            this.timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SendNotification("Напоминание", "Пора сделать перерыв!");
        }

        public void Start()
        {
            this.timer.Start();
        }

        public void Stop()
        {
            this.timer.Stop();
        }

        private void SendNotification(string title, string message)
        {
            notifyIcon.BalloonTipTitle = title;
            notifyIcon.BalloonTipText = message;
            notifyIcon.ShowBalloonTip(3000); // Показывает уведомление на 3 секунды
        }
    }
}
