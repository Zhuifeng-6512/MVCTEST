using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCTEST
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //string strFilePath = @"D:\LogInfo.txt";
            //using (System.IO.StreamWriter sw = new System.IO.StreamWriter(strFilePath))
            //{
            //    sw.WriteLine("网站启动");
            //    sw.Close();
            //}

            // 注册所有区域路由
            AreaRegistration.RegisterAllAreas();
            // 注册过滤器
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            // 注册路由
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            // 绑定
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
