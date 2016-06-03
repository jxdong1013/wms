using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMSModel
{
    public class WMSData
    {
        private string currentDate;
        private string currentYear;

        public string CurrentYear
        {
            get { return currentYear; }
            set { currentYear = value; }
        }
        private string currentMonth;

        public string CurrentMonth
        {
            get { return currentMonth; }
            set { currentMonth = value; }
        }
        private string currentDay;

        public string CurrentDay
        {
            get { return currentDay; }
            set { currentDay = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        private long totalCount;



        private DocumentData inDocument;


        private DocumentData borrowDocument;


        private DocumentData outDocument;


        private DocumentData destoryDocument;


        private String threeDUrl;


        private long todayInOutCount;


        private WareHourseData wareHourseOne;


        private WareHourseData wareHourseTwo;


        private WareHourseData wareHourseThree;


        private WareHourseCheckData wareHourseCheck;

        public string CurrentDate
        {
            get { return currentDate; }
            set { currentDate = value; }
        }
        public long TotalCount
        {
            get { return totalCount; }
            set { totalCount = value; }
        }

        public DocumentData InDocument
        {
            get { return inDocument; }
            set { inDocument = value; }
        }
        public DocumentData BorrowDocument
        {
            get { return borrowDocument; }
            set { borrowDocument = value; }
        }
        public DocumentData OutDocument
        {
            get { return outDocument; }
            set { outDocument = value; }
        }
        public DocumentData DestoryDocument
        {
            get { return destoryDocument; }
            set { destoryDocument = value; }
        }
        public String ThreeDUrl
        {
            get { return threeDUrl; }
            set { threeDUrl = value; }
        }
        public long TodayInOutCount
        {
            get { return todayInOutCount; }
            set { todayInOutCount = value; }
        }

        public WareHourseData WareHourseOne
        {
            get { return wareHourseOne; }
            set { wareHourseOne = value; }
        }
        public WareHourseData WareHourseTwo
        {
            get { return wareHourseTwo; }
            set { wareHourseTwo = value; }
        }
        public WareHourseData WareHourseThree
        {
            get { return wareHourseThree; }
            set { wareHourseThree = value; }
        }
        public WareHourseCheckData WareHourseCheck
        {
            get { return wareHourseCheck; }
            set { wareHourseCheck = value; }
        }
    }

    public class DocumentData{
        private long totalShift;
        private long totalBox;
        private long totalPackage;

        public long TotalShift { get { return totalShift; } set { totalShift = value; } }
        public long TotalBox { get { return totalBox; } set { totalBox = value; } }
        public long TotalPackage { get { return totalPackage; } set { totalPackage = value; } }
    }

    public class WareHourseData{
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string temperature;

        public string Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        private string humidity;

        public string Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }

    }

    public class WareHourseCheckData
    {
        private int checkMonthCount;

        public int CheckMonthCount
        {
            get { return checkMonthCount; }
            set { checkMonthCount = value; }
        }
        private int reportMonthCount;

        public int ReportMonthCount
        {
            get { return reportMonthCount; }
            set { reportMonthCount = value; }
        }
        private int repairMonthCount;

        public int RepairMonthCount
        {
            get { return repairMonthCount; }
            set { repairMonthCount = value; }
        }
        private int warnMonthCount;

        public int WarnMonthCount
        {
            get { return warnMonthCount; }
            set { warnMonthCount = value; }
        }

    }
}
