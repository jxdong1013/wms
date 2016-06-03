using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using Common.Logging;

namespace WMSWindowsService
{
    public partial class WMSService : ServiceBase
    {
        Quartz.ISchedulerFactory factory = null;
        Quartz.IScheduler scheduler=null;
        private static readonly ILog logger = LogManager.GetLogger(typeof(WMSService));

        public WMSService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {

                factory = new Quartz.Impl.StdSchedulerFactory();

                scheduler = factory.GetScheduler();

                scheduler.Start();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }

        }



        protected override void OnStop()
        {
            if (scheduler == null) return;
            scheduler.Shutdown(true);
        }

    }
}
