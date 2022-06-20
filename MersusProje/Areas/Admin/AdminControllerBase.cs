using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MersusProje.Areas.Admin
{
    public class AdminControllerBase : Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            var IsLogin = false;
            if(requestContext.HttpContext.Session["AdminLoginUser"] == null)
            {
                //Admin Giriş Yapmamış
                requestContext.HttpContext.Response.Redirect("/Admin/AdminLogin");
                
            }
            else
            {
                //Admin Giriş Yapmış
                base.Initialize(requestContext);
            }
            
        }
    }
}