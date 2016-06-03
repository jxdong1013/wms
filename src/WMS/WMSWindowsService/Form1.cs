using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WMSWindowsService
{
    public partial class Form1 : Form
    {
        Quartz.ISchedulerFactory factory = null;
        Quartz.IScheduler scheduler = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                factory = new Quartz.Impl.StdSchedulerFactory();

                scheduler = factory.GetScheduler();

                scheduler.Start();
            }
            catch (Exception ex)
            {
                String s = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (scheduler == null) return;
            scheduler.Shutdown(true);
        }
    }
}
