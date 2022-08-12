using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarOOP
{
    public partial class myUserControl : UserControl
    {
        bool _isBlank = true;
        public Button btnUC = new Button();
        public static string selectedDate;
        public myUserControl(Boolean isBlank, int i)
        {
            InitializeComponent();
            _isBlank = isBlank;

            addButton();

            if (_isBlank)
            {
                blankButtonUI();
            }
            else
            {
                dateButtonUI(i);
                addEventClick();
            }
        }
        
        private void addButton()
        {
            this.Controls.Add(btnUC);
            btnUC.Size = new Size(33, 33);
            btnUC.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void blankButtonUI()
        {
            btnUC.Text = "";
            btnUC.FlatStyle = FlatStyle.Flat;
            btnUC.BackColor = SystemColors.Control;
            btnUC.FlatAppearance.BorderColor = SystemColors.Control;
            btnUC.FlatAppearance.BorderSize = 0;
        }

        private void dateButtonUI(int i)
        {
            btnUC.Text = i.ToString();
        }

        private void addEventClick()
        {
            btnUC.Click += BtnUC_Click;
            btnUC.MouseHover += BtnUC_MouseHover;
        }

        public void BtnUC_MouseHover(object sender, EventArgs e)
        {
            displayTooltip();
        }

        public void displayTooltip()
        {
            var holidaydic = Holiday.holidayDictionary;
            if (holidaydic.ContainsKey(selectDate(btnUC.Text)))
            {
                ToolTip btnToolTip = new ToolTip();
                btnToolTip.SetToolTip(btnUC, holidaydic[selectDate(btnUC.Text)]);
            }
        }

        public string selectDate(string btnText)
        {
            int selmonth = Calendar.month;
            int selyear = Calendar.year;
            string date = btnText;

            return ($"{date}/{selmonth}/{selyear}");
        }
        private void BtnUC_Click(object sender, EventArgs e)
        {
            selectedDate = selectDate(btnUC.Text);
            displayHoliday displayHolidays = new displayHoliday();
            displayHolidays.ShowDialog();
            btnUC.BackColor=SystemColors.Info;
        }
    }
}
