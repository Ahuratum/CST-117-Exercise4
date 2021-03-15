using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            string str_entry = tb_user_entry.Text;
            ClearForm();
            string display_entry = "You have entered " + str_entry;
            lbl_user_entry.Text = display_entry;
            long num_entry = long.Parse(str_entry);
            CalculateData(num_entry);
        }
        private void ClearForm()
        {
            tb_user_entry.Clear();
            tb_secs.Clear();
            tb_mins.Clear();
            tb_hours.Clear();
            tb_days.Clear();
            tb_weeks.Clear();
            tb_months.Clear();
            tb_years.Clear();
        }
        private void CalculateData(long user_entry)
        {
            if (user_entry >= 31536000)
            {
                long years = user_entry / 31536000;
                tb_years.Text = years.ToString();
                user_entry = user_entry % 31536000;
            }
            if (user_entry >= 2628288)
            {
                long months = user_entry / 2628288;
                tb_months.Text = months.ToString();
                user_entry = user_entry % 2628288;
            }
            if (user_entry >= 604800)
            {
                long weeks = user_entry / 604800;
                tb_weeks.Text = weeks.ToString();
                user_entry = user_entry % 604800;
            }
            if (user_entry >= 86400)
            {
                long days = user_entry / 86400;
                tb_days.Text = days.ToString();
                user_entry = user_entry % 86400;
            }
            if (user_entry >= 3600)
            {
                long hours = user_entry / 3600;
                tb_hours.Text = hours.ToString();
                user_entry = user_entry % 3600;
            }
            if (user_entry >= 60)
            {
                long minutes = user_entry / 60;
                tb_mins.Text = minutes.ToString();
                user_entry = user_entry % 60;
            }
            tb_secs.Text = user_entry.ToString();
        }
        private long CalculateYears(long user_entry)
        {
            long years = user_entry / 31536000;
            tb_years.Text = years.ToString();
            user_entry = user_entry % 31536000;
            return user_entry;
        }
    }
}
