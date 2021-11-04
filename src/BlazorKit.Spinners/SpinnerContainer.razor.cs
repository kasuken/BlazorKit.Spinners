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
    }
}
