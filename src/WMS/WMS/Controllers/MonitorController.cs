using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceStack.Redis;
using WMS.App_Code;

namespace WMS.Controllers
{
    public class MonitorController : Controller
    {
        //
        // GET: /Monotor/

        public ActionResult Index()
        {
            WMSModel.WMSData data = GetDataFromRedis();
            return View( data );
        }

        public JsonResult GetData()
        {
            WMSModel.WMSData data = GetDataFromRedis();
            JsonResult result = new JsonResult();
            result.Data = data;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        } 

        protected WMSModel.WMSData GetDataFromRedis()
        {
            IRedisClient redisClient = RedisManager.GetClient();

            WMSModel.WMSData data = redisClient.Get<WMSModel.WMSData>("data");
            if (data == null)
            {
                data = new WMSModel.WMSData();
            }

            ViewBag.currentDate = data.CurrentDate;
            ViewBag.currentYear = data.CurrentYear;
            ViewBag.currentMonth = data.CurrentMonth;
            ViewBag.currentDay = data.CurrentDay;
            ViewBag.totalCount = data.TotalCount;

            return data;
            
        }

    }
}
