using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTagHelpers.Library
{
    public class ShowNameAsListTagHelper : TagHelper
    {
        public List<string> Names { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // <ul> </ul>


            output.TagName = "ul";

            foreach (var name in Names)
            {
                output.Content.AppendHtml($"<li>{name}</li>");
            }

            //output.Content.SetHtmlContent("<li>ahmet</li>");
        }
    }
}
