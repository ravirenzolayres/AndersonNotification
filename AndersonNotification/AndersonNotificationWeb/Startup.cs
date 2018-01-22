using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using System.Web.Mvc;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;

namespace AndersonNotificationWeb
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            //ConfigureCookie(app);   
        }   

        //public void ConfigureCookie(IAppBuilder app)
        //{
        //    app.UseCookieAuthentication(new CookieAuthenticationOptions
        //    {
        //        AuthenticationType = "ApplicationCookie",
        //        LoginPath = new PathString("/Credential/Login")
        //    });
        //}
    }
}
