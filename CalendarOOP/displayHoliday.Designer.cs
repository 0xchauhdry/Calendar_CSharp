
namespace CalendarOOP
{
    partial class displayHoliday
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
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDisplaySelectedDate = new System.Windows.Forms.Label();
            this.txtHoliday = new System.Windows.Forms.TextBox();
            this.btnAddHoliday = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 23);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Holiday Description:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDisplaySelectedDate
            // 
            this.lblDisplaySelectedDate.Location = new System.Drawing.Point(12, 32);
            this.lblDisplaySelectedDate.Name = "lblDisplaySelectedDate";
            this.lblDisplaySelectedDate.Size = new System.Drawing.Size(100, 23);
            this.lblDisplaySelectedDate.TabIndex = 2;
            this.lblDisplaySelectedDate.Text = "show date here";
            this.lblDisplaySelectedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHoliday
            // 
            this.txtHoliday.Location = new System.Drawing.Point(15, 100);
            this.txtHoliday.Name = "txtHoliday";
            this.txtHoliday.Size = new System.Drawing.Size(196, 20);
            this.txtHoliday.TabIndex = 3;
            // 
            // btnAddHoliday
            // 
            this.btnAddHoliday.Location = new System.Drawing.Point(52, 136);
            this.btnAddHoliday.Name = "btnAddHoliday";
            this.btnAddHoliday.Size = new System.Drawing.Size(125, 23);
            this.btnAddHoliday.TabIndex = 4;
            this.btnAddHoliday.Text = "Add Holiday";
            this.btnAddHoliday.UseVisualStyleBackColor = true;
            this.btnAddHoliday.Click += new System.EventHandler(this.btnAddHoliday_Click);
            // 
            // displayHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 171);
            this.Controls.Add(this.btnAddHoliday);
            this.Controls.Add(this.txtHoliday);
            this.Controls.Add(this.lblDisplaySelectedDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDate);
            this.Name = "displayHoliday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "displayHoliday";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisplaySelectedDate;
        private System.Windows.Forms.TextBox txtHoliday;
        private System.Windows.Forms.Button btnAddHoliday;
    }
}