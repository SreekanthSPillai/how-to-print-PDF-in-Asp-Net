using System.Web;
using System.Web.Mvc;

namespace how_to_print_PDF_in_Asp_Net
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
