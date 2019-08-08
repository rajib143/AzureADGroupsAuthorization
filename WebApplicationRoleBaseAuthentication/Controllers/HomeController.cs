﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationRoleBaseAuthentication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app roles.";

            ClaimsIdentity claimsId = ClaimsPrincipal.Current.Identity as ClaimsIdentity;
            var appRoles = new List<String>();
            foreach (Claim claim in ClaimsPrincipal.Current.FindAll("roles"))
                appRoles.Add(claim.Value);
            ViewData["appRoles"] = appRoles;

            var userClaims = User.Identity as System.Security.Claims.ClaimsIdentity;

            //You get the user’s first and last name below:
            ViewBag.Name = userClaims?.FindFirst("name")?.Value;

            // The 'preferred_username' claim can be used for showing the username
            ViewBag.Username = userClaims?.FindFirst("preferred_username")?.Value;

            // The subject/ NameIdentifier claim can be used to uniquely identify the user across the web
            ViewBag.Subject = userClaims?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            // TenantId is the unique Tenant Id - which represents an organization in Azure AD
            ViewBag.TenantId = userClaims?.FindFirst("http://schemas.microsoft.com/identity/claims/tenantid")?.Value;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}