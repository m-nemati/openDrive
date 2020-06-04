using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FTP_3768
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", @"\\192.168.68.10\fava");
            }
            catch
            {
                MessageBox.Show("عملیات ناموفق: وضعیت اتصال یا دسترسی به شبکه خود را چک نمائید");
            }
        }
    }
}
