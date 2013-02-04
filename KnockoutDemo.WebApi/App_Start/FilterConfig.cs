using System.Web;
using System.Web.Mvc;
using KnokoutDemo.WebApi.Filters;

namespace KnokoutDemo.WebApi
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