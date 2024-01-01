﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Assignment5.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = (await output.GetChildContentAsync()).GetContent();
            output.Attributes.Add("href", "mailto: " + content);
            output.Content.SetContent("Drop us a mail");
        }
    }
}
