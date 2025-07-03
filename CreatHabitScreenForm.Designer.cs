namespace Example
{
    partial class CreatHabitScreenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.goal = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.Label();
            this.reminder = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.DaysBox = new System.Windows.Forms.MaskedTextBox();
            this.GoalBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ReminderBox = new System.Windows.Forms.MaskedTextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(189)))), ((int)(((byte)(164)))));
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.save.Location = new System.Drawing.Point(564, 25);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(134, 37);
            this.save.TabIndex = 0;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Создание привычки";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(87, 133);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(122, 29);
            this.name.TabIndex = 3;
            this.name.Text = "Название";
            // 
            // goal
            // 
            this.goal.AutoSize = true;
            this.goal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goal.Location = new System.Drawing.Point(87, 234);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(70, 29);
            this.goal.TabIndex = 4;
            this.goal.Text = "Цель";
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.days.Location = new System.Drawing.Point(87, 333);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(209, 29);
            this.days.TabIndex = 5;
            this.days.Text = "Количество дней";
            // 
            // reminder
            // 
            this.reminder.AutoSize = true;
            this.reminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reminder.Location = new System.Drawing.Point(87, 434);
            this.reminder.Name = "reminder";
            this.reminder.Size = new System.Drawing.Size(171, 29);
            this.reminder.TabIndex = 6;
            this.reminder.Text = "Напоминание";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.Location = new System.Drawing.Point(87, 532);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(125, 29);
            this.description.TabIndex = 7;
            this.description.Text = "Описание";
            // 
            // DaysBox
            // 
            this.DaysBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(189)))), ((int)(((byte)(164)))));
            this.DaysBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DaysBox.Location = new System.Drawing.Point(92, 389);
            this.DaysBox.Mask = "00";
            this.DaysBox.Name = "DaysBox";
            this.DaysBox.Size = new System.Drawing.Size(518, 30);
            this.DaysBox.TabIndex = 8;
            this.DaysBox.ValidatingType = typeof(int);
            // 
            // GoalBox
            // 
            this.GoalBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(189)))), ((int)(((byte)(164)))));
            this.GoalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoalBox.Location = new System.Drawing.Point(92, 279);
            this.GoalBox.Multiline = true;
            this.GoalBox.Name = "GoalBox";
            this.GoalBox.Size = new System.Drawing.Size(518, 42);
            this.GoalBox.TabIndex = 9;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(189)))), ((int)(((byte)(164)))));
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(92, 177);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(518, 43);
            this.NameBox.TabIndex = 10;
            // 
            // ReminderBox
            // 
            this.ReminderBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(189)))), ((int)(((byte)(164)))));
            this.ReminderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReminderBox.Location = new System.Drawing.Point(92, 493);
            this.ReminderBox.Mask = "00:00";
            this.ReminderBox.Name = "ReminderBox";
            this.ReminderBox.Size = new System.Drawing.Size(518, 30);
            this.ReminderBox.TabIndex = 11;
            this.ReminderBox.ValidatingType = typeof(System.DateTime);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(189)))), ((int)(((byte)(164)))));
            this.DescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionBox.Location = new System.Drawing.Point(92, 589);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(518, 164);
            this.DescriptionBox.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(189)))), ((int)(((byte)(164)))));
            this.button2.Image = global::Example.Properties.Resources.Rack;
            this.button2.Location = new System.Drawing.Point(12, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 37);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreatHabitScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(252)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(710, 842);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.ReminderBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.GoalBox);
            this.Controls.Add(this.DaysBox);
            this.Controls.Add(this.description);
            this.Controls.Add(this.reminder);
            this.Controls.Add(this.days);
            this.Controls.Add(this.goal);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreatHabitScreenForm";
            this.Text = "CreatHabitScreenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label goal;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.Label reminder;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.MaskedTextBox DaysBox;
        private System.Windows.Forms.TextBox GoalBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.MaskedTextBox ReminderBox;
        private System.Windows.Forms.TextBox DescriptionBox;
    }
}