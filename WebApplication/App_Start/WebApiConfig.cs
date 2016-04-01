using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace WebApplication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "AnnotationsApi",
                routeTemplate: "api/annotations/{id}",
                defaults: new {controller = "Annotations", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name:"PostsApi",
                routeTemplate:"api/posts/{id}",
                defaults: new { controller = "Posts", id = RouteParameter.Optional }
                );
            

            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = 
                new CamelCasePropertyNamesContractResolver();
        }
    }
}
