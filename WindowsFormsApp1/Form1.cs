using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAbort_Click(object sender, EventArgs e)
        {
            Process.Start("Shutdown", "/a");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            string Timer = textBox1.Text;
            if (Timer == null)
            {

            }
            else
            {
                Process.Start("Shutdown", "/s /f /t " + Timer);
            }
        }
    }
}
