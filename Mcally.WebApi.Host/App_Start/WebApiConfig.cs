using Mcally.Web.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Mcally.WebApi.Host
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            // Web API 路由
            //跨域配置
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "McallyApi",
                 routeTemplate: "api/{controller}/{Action}/{id}",
            defaults: new { Action = RouteParameter.Optional, id = RouteParameter.Optional });
            config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator(new JsonMediaTypeFormatter()));

          
        }
    }
}
