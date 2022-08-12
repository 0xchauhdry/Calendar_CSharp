
namespace CalendarOOP
{
    partial class Calendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblMonthAndYear = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnMonday = new System.Windows.Forms.Button();
            this.btnTuesday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.Thursday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.pnlDaysContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.newTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblCurrentTime);
            this.flowLayoutPanel1.Controls.Add(this.lblCurrentDate);
            this.flowLayoutPanel1.Controls.Add(this.lblMonthAndYear);
            this.flowLayoutPanel1.Controls.Add(this.btnPrevious);
            this.flowLayoutPanel1.Controls.Add(this.btnNext);
            this.flowLayoutPanel1.Controls.Add(this.btnSunday);
            this.flowLayoutPanel1.Controls.Add(this.btnMonday);
            this.flowLayoutPanel1.Controls.Add(this.btnTuesday);
            this.flowLayoutPanel1.Controls.Add(this.btnWednesday);
            this.flowLayoutPanel1.Controls.Add(this.Thursday);
            this.flowLayoutPanel1.Controls.Add(this.btnFriday);
            this.flowLayoutPanel1.Controls.Add(this.btnSaturday);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(280, 127);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(3, 0);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(222, 40);
            this.lblCurrentTime.TabIndex = 0;
            this.lblCurrentTime.Text = "Current Time";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.Location = new System.Drawing.Point(3, 40);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(205, 23);
            this.lblCurrentDate.TabIndex = 1;
            this.lblCurrentDate.Text = "Current Time";
            this.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMonthAndYear
            // 
            this.lblMonthAndYear.Location = new System.Drawing.Point(3, 63);
            this.lblMonthAndYear.Name = "lblMonthAndYear";
            this.lblMonthAndYear.Size = new System.Drawing.Size(189, 23);
            this.lblMonthAndYear.TabIndex = 2;
            this.lblMonthAndYear.Text = "Current Time";
            this.lblMonthAndYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(198, 66);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(33, 25);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(237, 66);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(33, 25);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSunday
            // 
            this.btnSunday.Location = new System.Drawing.Point(3, 97);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(33, 25);
            this.btnSunday.TabIndex = 9;
            this.btnSunday.Text = "Su";
            this.btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnMonday
            // 
            this.btnMonday.Location = new System.Drawing.Point(42, 97);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(33, 25);
            this.btnMonday.TabIndex = 8;
            this.btnMonday.Text = "Mo";
            this.btnMonday.UseVisualStyleBackColor = true;
            // 
            // btnTuesday
            // 
            this.btnTuesday.Location = new System.Drawing.Point(81, 97);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(33, 25);
            this.btnTuesday.TabIndex = 7;
            this.btnTuesday.Text = "Tu";
            this.btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btnWednesday
            // 
            this.btnWednesday.Location = new System.Drawing.Point(120, 97);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(33, 25);
            this.btnWednesday.TabIndex = 6;
            this.btnWednesday.Text = "We";
            this.btnWednesday.UseVisualStyleBackColor = true;
            // 
            // Thursday
            // 
            this.Thursday.Location = new System.Drawing.Point(159, 97);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(33, 25);
            this.Thursday.TabIndex = 5;
            this.Thursday.Text = "Th";
            this.Thursday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            this.btnFriday.Location = new System.Drawing.Point(198, 97);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(33, 25);
            this.btnFriday.TabIndex = 4;
            this.btnFriday.Text = "Fr";
            this.btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            this.btnSaturday.Location = new System.Drawing.Point(237, 97);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(33, 25);
            this.btnSaturday.TabIndex = 3;
            this.btnSaturday.Text = "Sa";
            this.btnSaturday.UseVisualStyleBackColor = true;
            // 
            // pnlDaysContainer
            // 
            this.pnlDaysContainer.Location = new System.Drawing.Point(12, 135);
            this.pnlDaysContainer.Name = "pnlDaysContainer";
            this.pnlDaysContainer.Size = new System.Drawing.Size(280, 257);
            this.pnlDaysContainer.TabIndex = 0;
            // 
            // newTimer
            // 
            this.newTimer.Enabled = true;
            this.newTimer.Interval = 1;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 395);
            this.Controls.Add(this.pnlDaysContainer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel pnlDaysContainer;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblMonthAndYear;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnMonday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button Thursday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Timer newTimer;
    }
}

