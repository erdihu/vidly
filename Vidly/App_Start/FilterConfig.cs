using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //Add authorization to global site. 
            //Can be overridden by adding [AllowAnonymous] attribute
            filters.Add(new AuthorizeAttribute());
        }
    }
}
