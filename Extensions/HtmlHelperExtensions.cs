using MoviedbMVC5.Models;
using Newtonsoft.Json;
using System.Web;
using System.Web.Mvc;

namespace MoviedbMVC5.Extensions
{
    public static class HtmlHelperExtensions
    {
        /*Covert model data to Json functions - use Json.Net package*/
        public static HtmlString HtmlConvertToJson(object model)
        {
            var settings = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore, Formatting = Formatting.Indented };

            return new HtmlString(JsonConvert.SerializeObject(model, settings));
        }

        /*Sorting functions - use Dynamic Linq package*/
        public static MvcHtmlString BuildSortableLink(this HtmlHelper htmlHelper, string fieldName, string actionName, string sortField, QueryOptions queryOptions) 
        { var urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext); 
            
            var isCurrentSortField = queryOptions.SortField == sortField; 
            
            return new MvcHtmlString(string.Format("<a href=\"{0}\">{1} {2}</a>", urlHelper.Action(actionName, new { SortField = sortField, SortOrder = (isCurrentSortField && queryOptions.SortOrder == SortOrder.ASC) ? SortOrder.DESC : SortOrder.ASC }), fieldName, BuildSortIcon(isCurrentSortField, queryOptions))); }
        
        private static string BuildSortIcon(bool isCurrentSortField, QueryOptions queryOptions) { string sortIcon = "sort"; if (isCurrentSortField) { sortIcon += "-by-alphabet"; if (queryOptions.SortOrder == SortOrder.DESC) sortIcon += "-alt"; } return string.Format("<span class=\"{0} {1}{2}\"></span>", "glyphicon", "glyphicon-", sortIcon); }
    }
}