using MersusProjeCore.Entity;
using System.Web.Mvc;
using System.Web.Routing;


namespace MersusProje
{
    public class AndControllerBase : Controller
    {
        /// <summary>
        ///  //Kullanici Login Kontrolü
        /// </summary>

        public bool IsLogin { get; private set; }

        //Giriş Yapan Kullanici ID
        public int LoginUserID { get; private set; }
        //Giriş Yapan Kullanıcı Entity
        public User LoginUserEntity { get; private set; }
        protected override void Initialize(RequestContext requestContext)
        {
            // Session["LoginUserID"] 
            // Session["LoginUser"]
            if (requestContext.HttpContext.Session["LoginUserID"] != null)
            {
                //Kullanici Giriş Yaptıysa
                IsLogin = true;
                LoginUserID = (int)requestContext.HttpContext.Session["LoginUserID"];

                LoginUserEntity = (MersusProjeCore.Entity.User)requestContext.HttpContext.Session["LoginUser"];

            }
            base.Initialize(requestContext);
        }
    }
}