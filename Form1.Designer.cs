namespace Schedulink
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 70);
            dateTimePicker1.MinDate = new DateTime(2025, 4, 8, 22, 24, 9, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2025, 4, 8, 22, 24, 9, 0);
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(439, 34);
            monthCalendar1.MinDate = new DateTime(2025, 4, 8, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(800, 450);
            Controls.Add(monthCalendar1);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Log In";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private MonthCalendar monthCalendar1;
    }
}
