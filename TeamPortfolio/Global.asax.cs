// <copyright file="Global.asax.cs" company="Ascension">
//  Copyright (c) Ascension. All rights reserved.
// </copyright>

namespace TeamPortfolio
{
    using System;
    using System.Web;
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    /// <summary>
    ///     The Global Object.
    /// </summary>
    public class Global : HttpApplication
    {
        /// <summary>
        ///     The web application start method.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event argument.</param>
        private void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}