using BlazorComponentUtilities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace BlazorKit.Spinners
{
    public class SpinnerBase : ComponentBase
    {
        [Parameter] public string AccentColor { get; set; }
        [Parameter] public string Color { get; set; }
        [Parameter] public bool Center { get; set; }
        [Parameter] public string Size { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, object> AdditionalAttributes { get; set; } = new Dictionary<string, Object>();

        public string CssClass =>
            CssBuilder.Default("")
            .AddClass("loaderCenter", Center)
            .AddClassFromAttributes(AdditionalAttributes)
        .Build();

        public string Style =>
            StyleBuilder.Empty()
            .AddStyle("height", Size, when: !string.IsNullOrEmpty(Size))
            .AddStyleFromAttributes(AdditionalAttributes)
        .NullIfEmpty();
    }
}
