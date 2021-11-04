using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorKit.Spinners
{
    public partial class SpinnerLoader
    {
        [Parameter]
        public SpinnerTemplate Spinner { get; set; }

        [Parameter]
        public bool IsLoading { get; set; }

        [Parameter]
        public bool HasError { get; set; }

        [Parameter]
        public RenderFragment LoadingTemplate { get; set; }

        [Parameter]
        public RenderFragment ContentTemplate { get; set; }

        [Parameter]
        public RenderFragment ErrorContentTemplate { get; set; }
    }
}
