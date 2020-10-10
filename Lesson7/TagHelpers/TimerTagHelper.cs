using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson7.TagHelpers
{
    public class TimerTagHelper : TagHelper
    {
        public List<string> Lines { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            string listContent = "";
            foreach (string item in Lines)
                listContent += "<li>" + item + "</li>";

            output.Content.SetHtmlContent(listContent);
        }
    }
}
