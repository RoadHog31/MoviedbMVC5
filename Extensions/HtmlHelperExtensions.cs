﻿using Newtonsoft.Json;
using System.Web;
using System.Web.Mvc;

namespace MoviedbMVC5.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static HtmlString HtmlConvertToJson(object model)
        {
            var settings = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore, Formatting = Formatting.Indented }; 
            
            return new HtmlString(JsonConvert.SerializeObject(model, settings));
        }
    } }