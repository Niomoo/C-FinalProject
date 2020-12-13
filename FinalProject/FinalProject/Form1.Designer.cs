namespace FinalProject
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yearCalendar = new System.Windows.Forms.MonthCalendar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tab = new System.Windows.Forms.TabControl();
            this.Year = new System.Windows.Forms.TabPage();
            this.Month = new System.Windows.Forms.TabPage();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.Week = new System.Windows.Forms.TabPage();
            this.Day = new System.Windows.Forms.TabPage();
            this.txtDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tab.SuspendLayout();
            this.Year.SuspendLayout();
            this.Month.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To-Do List";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.groupBox2.Location = new System.Drawing.Point(22, 568);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 245);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance";
            // 
            // yearCalendar
            // 
            this.yearCalendar.CalendarDimensions = new System.Drawing.Size(4, 3);
            this.yearCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yearCalendar.Location = new System.Drawing.Point(3, 3);
            this.yearCalendar.Name = "yearCalendar";
            this.yearCalendar.ShowToday = false;
            this.yearCalendar.TabIndex = 3;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.Year);
            this.tab.Controls.Add(this.Month);
            this.tab.Controls.Add(this.Week);
            this.tab.Controls.Add(this.Day);
            this.tab.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tab.Location = new System.Drawing.Point(338, 24);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1365, 789);
            this.tab.TabIndex = 4;
            // 
            // Year
            // 
            this.Year.Controls.Add(this.yearCalendar);
            this.Year.Location = new System.Drawing.Point(4, 39);
            this.Year.Name = "Year";
            this.Year.Padding = new System.Windows.Forms.Padding(3);
            this.Year.Size = new System.Drawing.Size(1357, 746);
            this.Year.TabIndex = 0;
            this.Year.Text = "Year";
            this.Year.UseVisualStyleBackColor = true;
            // 
            // Month
            // 
            this.Month.Controls.Add(this.monthCalendar2);
            this.Month.Location = new System.Drawing.Point(4, 39);
            this.Month.Name = "Month";
            this.Month.Padding = new System.Windows.Forms.Padding(3);
            this.Month.Size = new System.Drawing.Size(1357, 746);
            this.Month.TabIndex = 1;
            this.Month.Text = "Month";
            this.Month.UseVisualStyleBackColor = true;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(12, 12);
            this.monthCalendar2.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.monthCalendar2.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.ShowToday = false;
            this.monthCalendar2.TabIndex = 0;
            // 
            // Week
            // 
            this.Week.Location = new System.Drawing.Point(4, 39);
            this.Week.Name = "Week";
            this.Week.Size = new System.Drawing.Size(1357, 746);
            this.Week.TabIndex = 2;
            this.Week.Text = "Week";
            this.Week.UseVisualStyleBackColor = true;
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(4, 39);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(1357, 746);
            this.Day.TabIndex = 3;
            this.Day.Text = "Day";
            this.Day.UseVisualStyleBackColor = true;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("微軟正黑體", 48F);
            this.txtDate.Location = new System.Drawing.Point(1793, 24);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(163, 246);
            this.txtDate.TabIndex = 5;
            this.txtDate.Text = "1213";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.label2.Location = new System.Drawing.Point(1746, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "視窗Hw14";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.label3.Location = new System.Drawing.Point(1746, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "資結期中";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.label4.Location = new System.Drawing.Point(1746, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 50);
            this.label4.TabIndex = 8;
            this.label4.Text = "練球";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::FinalProject.Properties.Resources.user;
            this.pictureBox.Location = new System.Drawing.Point(1755, 542);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(287, 267);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2200, 890);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tab.ResumeLayout(false);
            this.Year.ResumeLayout(false);
            this.Month.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar yearCalendar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage Year;
        private System.Windows.Forms.TabPage Month;
        private System.Windows.Forms.TabPage Week;
        private System.Windows.Forms.TabPage Day;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

