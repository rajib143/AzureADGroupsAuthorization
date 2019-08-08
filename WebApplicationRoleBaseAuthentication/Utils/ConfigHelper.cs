using System;
using System.Configuration;
using System.Globalization;

namespace WebApplicationRoleBaseAuthentication.Utils
{
    public class ConfigHelper
    {
        /// <summary>
        /// The AAD Instance is the instance of Azure, for example public Azure or Azure China.
        /// </summary>
        public static string AADInstance { get; } = Util.EnsureTrailingSlash(ConfigurationManager.AppSettings["ida:AADInstance"]);

        /// <summary>
        /// The Client ID is used by the application to uniquely identify itself to Azure AD.
        /// </summary>
        public static string ClientId { get; } = ConfigurationManager.AppSettings["ida:ClientId"];

        /// <summary>
        /// The Post Logout Redirect Uri is the URL where the user will be redirected after they sign out.
        /// </summary>
        public static string PostLogoutRedirectUri { get; } = ConfigurationManager.AppSettings["ida:PostLogoutRedirectUri"];
        public static string RedirectUri { get; } = ConfigurationManager.AppSettings["ida:RedirectUri"];

        /// <summary>
        /// The TenantId is the DirectoryId of the Azure AD tenant being used in the sample
        /// </summary>
        public static string TenantId { get; } = ConfigurationManager.AppSettings["ida:TenantId"];

        /// <summary>
        /// The Authority is the sign-in URL of the tenant.
        /// </summary>
        public static string Authority = String.Format(CultureInfo.InvariantCulture, AADInstance, TenantId) + "/" ;

        /// <summary>
        /// The Azure AD 'common' endpoint to authenticate users for multi-tenant applications.
        /// </summary>
        public static string CommonAuthority = String.Format(CultureInfo.InvariantCulture, AADInstance, "common/");
    }
}