namespace FinalProject
{
    partial class Form_HabitChecking
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
            this.button_back = new System.Windows.Forms.Button();
            this.circleProgressBar = new FinalProject.CircleProgressBar();
            this.label_status_show = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label_completeNumber = new System.Windows.Forms.Label();
            this.label_complete = new System.Windows.Forms.Label();
            this.label_started = new System.Windows.Forms.Label();
            this.label_startedNumber = new System.Windows.Forms.Label();
            this.label_incomplete = new System.Windows.Forms.Label();
            this.label_incompleteNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.SkyBlue;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Location = new System.Drawing.Point(10, 10);
            this.button_back.Margin = new System.Windows.Forms.Padding(2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 35);
            this.button_back.TabIndex = 0;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // circleProgressBar
            // 
            this.circleProgressBar.BackColor = System.Drawing.Color.SkyBlue;
            this.circleProgressBar.BottomColor = System.Drawing.Color.Gainsboro;
            this.circleProgressBar.FinishedColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(179)))), ((int)(((byte)(63)))));
            this.circleProgressBar.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleProgressBar.Location = new System.Drawing.Point(35, 240);
            this.circleProgressBar.MaxValue = 100;
            this.circleProgressBar.Name = "circleProgressBar";
            this.circleProgressBar.Progress = 20;
            this.circleProgressBar.Size = new System.Drawing.Size(330, 330);
            this.circleProgressBar.TabIndex = 1;
            this.circleProgressBar.Text = "circleProgressBar1";
            this.circleProgressBar.TopColor = System.Drawing.Color.Crimson;
            // 
            // label_status_show
            // 
            this.label_status_show.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_status_show.Location = new System.Drawing.Point(135, 60);
            this.label_status_show.Name = "label_status_show";
            this.label_status_show.Size = new System.Drawing.Size(130, 70);
            this.label_status_show.TabIndex = 2;
            this.label_status_show.Text = "統計";
            this.label_status_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(50, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(130, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(210, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(290, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label_completeNumber
            // 
            this.label_completeNumber.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_completeNumber.ForeColor = System.Drawing.Color.Green;
            this.label_completeNumber.Location = new System.Drawing.Point(25, 580);
            this.label_completeNumber.Name = "label_completeNumber";
            this.label_completeNumber.Size = new System.Drawing.Size(100, 60);
            this.label_completeNumber.TabIndex = 7;
            this.label_completeNumber.Text = "65";
            this.label_completeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_complete
            // 
            this.label_complete.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_complete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_complete.Location = new System.Drawing.Point(25, 630);
            this.label_complete.Name = "label_complete";
            this.label_complete.Size = new System.Drawing.Size(100, 30);
            this.label_complete.TabIndex = 8;
            this.label_complete.Text = "已完成";
            this.label_complete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_started
            // 
            this.label_started.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_started.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_started.Location = new System.Drawing.Point(150, 630);
            this.label_started.Name = "label_started";
            this.label_started.Size = new System.Drawing.Size(100, 30);
            this.label_started.TabIndex = 10;
            this.label_started.Text = "已開始";
            this.label_started.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_startedNumber
            // 
            this.label_startedNumber.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startedNumber.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_startedNumber.Location = new System.Drawing.Point(150, 580);
            this.label_startedNumber.Name = "label_startedNumber";
            this.label_startedNumber.Size = new System.Drawing.Size(100, 60);
            this.label_startedNumber.TabIndex = 9;
            this.label_startedNumber.Text = "4";
            this.label_startedNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_incomplete
            // 
            this.label_incomplete.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_incomplete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_incomplete.Location = new System.Drawing.Point(275, 630);
            this.label_incomplete.Name = "label_incomplete";
            this.label_incomplete.Size = new System.Drawing.Size(100, 30);
            this.label_incomplete.TabIndex = 12;
            this.label_incomplete.Text = "未完成";
            this.label_incomplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_incompleteNumber
            // 
            this.label_incompleteNumber.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_incompleteNumber.ForeColor = System.Drawing.Color.Green;
            this.label_incompleteNumber.Location = new System.Drawing.Point(275, 580);
            this.label_incompleteNumber.Name = "label_incompleteNumber";
            this.label_incompleteNumber.Size = new System.Drawing.Size(100, 60);
            this.label_incompleteNumber.TabIndex = 11;
            this.label_incompleteNumber.Text = "16";
            this.label_incompleteNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_HabitChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(400, 700);
            this.Controls.Add(this.label_incomplete);
            this.Controls.Add(this.label_incompleteNumber);
            this.Controls.Add(this.label_started);
            this.Controls.Add(this.label_startedNumber);
            this.Controls.Add(this.label_complete);
            this.Controls.Add(this.label_completeNumber);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_status_show);
            this.Controls.Add(this.circleProgressBar);
            this.Controls.Add(this.button_back);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_HabitChecking";
            this.Text = "Habit Checking";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_HabitChecking_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private CircleProgressBar circleProgressBar;
        private System.Windows.Forms.Label label_status_show;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label_completeNumber;
        private System.Windows.Forms.Label label_complete;
        private System.Windows.Forms.Label label_started;
        private System.Windows.Forms.Label label_startedNumber;
        private System.Windows.Forms.Label label_incomplete;
        private System.Windows.Forms.Label label_incompleteNumber;
    }
}