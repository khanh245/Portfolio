﻿// <copyright file="BundleConfig.cs" company="Ascension">
//  Copyright (c) Ascension. All rights reserved.
// </copyright>

namespace TeamPortfolio
{
    using System;
    using System.Web.Optimization;

    /// <summary>
    /// Represents a Bundle Config.
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BundleConfig"/> class.
        /// </summary>
        /// <remarks>Prevents default constructor.</remarks>
        private BundleConfig()
        {
        }

        /// <summary>
        /// Register all bundles.
        /// </summary>
        /// <param name="bundles">The collection of bundles.</param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            if (bundles == null)
            {
                throw new ArgumentException("bundles");
            }

            bundles.IgnoreList.Clear();

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css",
                "~/Content/font-awesome.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}