using System.Web;
using System.Web.Mvc;

namespace BooksService_MicrosoftTutorial2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
