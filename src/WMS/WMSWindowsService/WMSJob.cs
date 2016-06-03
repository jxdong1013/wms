using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;
using Common.Logging;

namespace WMSWindowsService
{
    public class WMSJob:IJob
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(WMSJob));

        public void Execute(IJobExecutionContext context)
        {
            logger.Info("wmsjob start...");

           
            WMSModel.WMSData data= GetData();

            setRedis( data );

            logger.Info("wmsjob end..."); 
        }

        protected WMSModel.WMSData GetData()
        {
            Random random = new Random();

            WMSModel.WMSData data = new WMSModel.WMSData();
            data.CurrentDate = DateTime.Now.ToString();
            data.CurrentYear = DateTime.Now.Year.ToString();
            data.CurrentMonth = DateTime.Now.Month.ToString();
            data.CurrentDay = DateTime.Now.Day.ToString();
            data.TotalCount = random.Next(10000,1000000);

            data.ThreeDUrl = "http://www.baidu.com";

            data.TodayInOutCount = random.Next(30, 50);

            WMSModel.DocumentData inDocument = new WMSModel.DocumentData();
            inDocument.TotalBox = random.Next(100,1000);
            inDocument.TotalShift = 1000;
            inDocument.TotalPackage = 10000;

            data.InDocument = inDocument;

            WMSModel.DocumentData borrowDocument = new WMSModel.DocumentData();
            borrowDocument.TotalBox = new Random(borrowDocument.GetHashCode()).Next(200,1000);
            borrowDocument.TotalShift = new Random(borrowDocument.GetHashCode()).Next(20,2000);
            borrowDocument.TotalPackage = new Random(borrowDocument.GetHashCode()).Next(0,20000);

            data.BorrowDocument = borrowDocument;

            WMSModel.DocumentData outDocument = new WMSModel.DocumentData();
            outDocument.TotalBox = new Random(outDocument.GetHashCode()).Next(300, 3000);
            outDocument.TotalShift = new Random(outDocument.GetHashCode()).Next( 300, 3000);
            outDocument.TotalPackage =new Random(outDocument.GetHashCode()).Next( 33, 30000);

            data.OutDocument = outDocument;


            WMSModel.DocumentData destoryDocument = new WMSModel.DocumentData();
            destoryDocument.TotalBox = random.Next(400,4000);
            destoryDocument.TotalShift =4000;
            destoryDocument.TotalPackage = 40000;

            data.DestoryDocument = destoryDocument;

            WMSModel.WareHourseData warehourse = new WMSModel.WareHourseData();
            warehourse.Name = "库房1";
            warehourse.Temperature = random.Next(-10,50) + "°C";
            warehourse.Humidity = random.Next(0,100) + "%";
            data.WareHourseOne = warehourse;

            warehourse = new WMSModel.WareHourseData();
            warehourse.Name = "库房2";
            warehourse.Temperature = random.Next(-10, 50) + "°C";
            warehourse.Humidity = random.Next(0, 100) + "%";
            data.WareHourseTwo = warehourse;

            warehourse = new WMSModel.WareHourseData();
            warehourse.Name = "库房3";
            warehourse.Temperature = random.Next(-10, 50) + "°C";
            warehourse.Humidity = random.Next(0, 100) + "%";
            data.WareHourseThree = warehourse;

            WMSModel.WareHourseCheckData check = new WMSModel.WareHourseCheckData();
            check.CheckMonthCount =  random.Next(0,100) ;
            check.RepairMonthCount =  random.Next(0,100) ;
            check.ReportMonthCount =  random.Next(0,100) ;
            check.WarnMonthCount =  random.Next(0,100) ;

            data.WareHourseCheck = check;

            return data;

        }

        protected void setRedis( WMSModel.WMSData data )
        {
            //ServiceStack.Redis.RedisClient redisClient=new ServiceStack.Redis.RedisClient();
            //redisClient.
            ServiceStack.Redis.IRedisClient redisClient = RedisManager.GetClient();
            redisClient.Set<WMSModel.WMSData>("data", data);
            

        }

      
    }
}
