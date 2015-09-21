// <copyright file="WebApiConfig.cs" company="Ascension">
//  Copyright (c) Ascension. All rights reserved.
// </copyright>

namespace TeamPortfolio
{
    using System.Web.Http;

    /// <summary>
    /// Represents the Web API Config.
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registers all web config.
        /// </summary>
        /// <param name="config">The config.</param>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new { id = RouteParameter.Optional });
        }
    }
}