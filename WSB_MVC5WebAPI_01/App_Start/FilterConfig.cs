using System.Web;
using System.Web.Mvc;

namespace WSB_MVC5WebAPI_01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
