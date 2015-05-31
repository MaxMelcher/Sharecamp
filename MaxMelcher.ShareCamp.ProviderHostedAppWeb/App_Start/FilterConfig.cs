using System.Web;
using System.Web.Mvc;

namespace MaxMelcher.ShareCamp.ProviderHostedAppWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
