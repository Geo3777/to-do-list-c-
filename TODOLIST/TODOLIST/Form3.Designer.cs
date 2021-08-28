
namespace ToDoLIst
{
    partial class Form3
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
            this.LabeTask = new System.Windows.Forms.Label();
            this.NumeTask = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label2223 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.TaskBack = new System.Windows.Forms.Button();
            this.TaskSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabeTask
            // 
            this.LabeTask.AutoSize = true;
            this.LabeTask.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.LabeTask.Location = new System.Drawing.Point(147, 26);
            this.LabeTask.Name = "LabeTask";
            this.LabeTask.Size = new System.Drawing.Size(140, 30);
            this.LabeTask.TabIndex = 2;
            this.LabeTask.Text = "Task Designer";
            // 
            // NumeTask
            // 
            this.NumeTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NumeTask.Location = new System.Drawing.Point(12, 120);
            this.NumeTask.Name = "NumeTask";
            this.NumeTask.Size = new System.Drawing.Size(379, 29);
            this.NumeTask.TabIndex = 3;
            this.NumeTask.TextChanged += new System.EventHandler(this.NumeTask_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label22.Location = new System.Drawing.Point(12, 92);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(106, 25);
            this.label22.TabIndex = 4;
            this.label22.Text = "Task Name:";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label2223
            // 
            this.label2223.AutoSize = true;
            this.label2223.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2223.Location = new System.Drawing.Point(12, 172);
            this.label2223.Name = "label2223";
            this.label2223.Size = new System.Drawing.Size(55, 25);
            this.label2223.TabIndex = 5;
            this.label2223.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Time:";
            // 
            // Time
            // 
            this.Time.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time.Location = new System.Drawing.Point(12, 330);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(379, 29);
            this.Time.TabIndex = 8;
            this.Time.Value = new System.DateTime(2021, 5, 29, 0, 0, 0, 0);
            this.Time.ValueChanged += new System.EventHandler(this.Time_ValueChanged);
            // 
            // Date
            // 
            this.Date.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.Date.CustomFormat = "yyyy-MM-dd";
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date.Location = new System.Drawing.Point(12, 213);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(379, 29);
            this.Date.TabIndex = 9;
            this.Date.Value = new System.DateTime(2021, 5, 29, 0, 0, 0, 0);
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // TaskBack
            // 
            this.TaskBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TaskBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskBack.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TaskBack.Location = new System.Drawing.Point(12, 591);
            this.TaskBack.Name = "TaskBack";
            this.TaskBack.Size = new System.Drawing.Size(89, 32);
            this.TaskBack.TabIndex = 10;
            this.TaskBack.Text = "Back";
            this.TaskBack.UseVisualStyleBackColor = false;
            this.TaskBack.Click += new System.EventHandler(this.TaskBack_Click);
            // 
            // TaskSave
            // 
            this.TaskSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TaskSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TaskSave.Location = new System.Drawing.Point(318, 591);
            this.TaskSave.Name = "TaskSave";
            this.TaskSave.Size = new System.Drawing.Size(89, 32);
            this.TaskSave.TabIndex = 11;
            this.TaskSave.Text = "Save Task";
            this.TaskSave.UseVisualStyleBackColor = false;
            this.TaskSave.Click += new System.EventHandler(this.TaskSave_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(419, 635);
            this.Controls.Add(this.TaskSave);
            this.Controls.Add(this.TaskBack);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2223);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.NumeTask);
            this.Controls.Add(this.LabeTask);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabeTask;
        private System.Windows.Forms.TextBox NumeTask;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label2223;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Time;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button TaskBack;
        private System.Windows.Forms.Button TaskSave;
    }
}