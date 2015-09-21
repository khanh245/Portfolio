// <copyright file="ContactController.cs" company="Ascension">
//  Copyright (c) Ascension. All rights reserved.
// </copyright>

namespace TeamPortfolio.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    ///     Represents a Contact Controller.
    /// </summary>
    public class ContactController : Controller
    {
        /// <summary>
        ///     The MeetUs Page.
        /// </summary>
        /// <returns>The Meet Us View</returns>
        public ActionResult MeetUs()
        {
            return this.View();
        }
    }
}