using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace WSB_MVC5WebAPI_01
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Enable the application to use a cookie to store information for the signed in user
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
            // Use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Uncomment the following lines to enable logging in with third party login providers
            // app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

           // app.UseTwitterAuthentication(
           //    consumerKey: "",
           //    consumerSecret: "");

              app.UseFacebookAuthentication(
                appId: "402695379909880",
                appSecret: "1dc4d1f10fa824588976810f9c9cab62");

              app.UseGoogleAuthentication(
                clientId: "93305523919-v1d4ur9gjg6h46g1m1k6s40vdgspsnsp.apps.googleusercontent.com",
                clientSecret: "pfkv3soJrdPLPaecQzC_SsEU");
        }
    }
}