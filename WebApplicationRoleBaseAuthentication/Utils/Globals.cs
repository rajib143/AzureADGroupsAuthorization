﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationRoleBaseAuthentication.Utils
{
    public static class Globals
    {
        private static string objectIdClaimType = "http://schemas.microsoft.com/identity/claims/objectidentifier";
        private const string tenantIdClaimType = "http://schemas.microsoft.com/identity/claims/tenantid";
        private static List<String> taskStatuses = new List<String>(new String[4] { "Not  Started", "In Progress", "Complete", "Blocked" });

        internal static string ObjectIdClaimType { get { return objectIdClaimType; } }
        internal static string TenantIdClaimType { get { return tenantIdClaimType; } }
        public static List<String> Statuses { get { return taskStatuses; } }
    }
}