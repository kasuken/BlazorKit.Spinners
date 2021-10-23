using BlazorComponentUtilities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorKit.Spinners
{
    partial class SpinnerContainer
    {
        [Parameter] 
        public RenderFragment ChildContent { get; set; }
        [Parameter] 
        public string BaseCss { get; set; }
        
        string CssClass =>
            CssBuilder.Default(BaseCss)
            .AddClass("sk-center", Center)
            .AddClassFromAttributes(AdditionalAttributes)
        .Build();

        string Style =>
            StyleBuilder.Empty()
            .AddStyle("--sk-color", Color, when: !string.IsNullOrEmpty(Color))
            .AddStyle("--sk-size", Size, when: !string.IsNullOrEmpty(Size))
            .AddStyleFromAttributes(AdditionalAttributes)
        .NullIfEmpty();
    }
}
