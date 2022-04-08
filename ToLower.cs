using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabsTPV2._3
{
    public static class ToLower
    {
        public static HtmlString ToLow(this IHtmlHelper html, string item)
        {
            return new HtmlString(item.ToLower());
        }
    }
}
