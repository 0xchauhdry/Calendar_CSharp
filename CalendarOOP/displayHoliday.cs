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
    public partial class displayHoliday : Form
    {
        public displayHoliday()
        {
            InitializeComponent();
            showdate();
        }

        public void showdate()
        {
            lblDisplaySelectedDate.Text = myUserControl.selectedDate;
        }

        private void btnAddHoliday_Click(object sender, EventArgs e)
        {
            Holiday.holidayDate = myUserControl.selectedDate;
            Holiday.holidayDescription = txtHoliday.Text;
            Holiday.UpdateHolidays();
            Close();
        }
    }
}
