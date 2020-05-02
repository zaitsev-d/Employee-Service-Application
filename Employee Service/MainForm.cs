using Employee_Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Service_Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelDateTime.Text = $"{DateTime.Now.DayOfWeek}, {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month)}  [ {DateTime.Now.ToShortDateString()} ]  {DateTime.Now.ToShortTimeString()}";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = $"{DateTime.Now.DayOfWeek}, {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month)}  [ {DateTime.Now.ToShortDateString()} ]  {DateTime.Now.ToShortTimeString()}";
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutorizationForm autorizationForm = new AutorizationForm();
            autorizationForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
