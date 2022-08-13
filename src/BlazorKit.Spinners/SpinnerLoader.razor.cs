namespace BlazorKit.Spinners;
public partial class SpinnerLoader
{
    public SpinnerTemplate Spinner { get; set; }

    [Parameter] public bool IsLoading { get; set; }

    [Parameter] public bool HasError { get; set; }

    [Parameter] public RenderFragment LoadingTemplate { get; set; }

    [Parameter] public RenderFragment ContentTemplate { get; set; }

    [Parameter] public RenderFragment ErrorContentTemplate { get; set; }
}