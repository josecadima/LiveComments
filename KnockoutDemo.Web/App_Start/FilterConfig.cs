using System.Web;
using System.Web.Mvc;
using KnockoutDemo.Filters;

namespace KnockoutDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new JsonExceptionFilterAttribute());
        }
    }
}