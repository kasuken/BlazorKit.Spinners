# BlazorKit.Spinners

A Blazor library for loading spinners.

## Screenshots

![App Screenshot](https://raw.githubusercontent.com/kasuken/BlazorKit.Spinners/dev/blazorkit.spinners.gif)

## Installation

With Package Manager:

```gitattributes
Install-Package BlazorKit.Spinners
```

With .NET CLI:

```gitattributes
dotnet add package BlazorKit.Spinners
```

## How to use it

If the project is Blazor WebAssembly, it is also necessary to modify the INDEX.HTML page present in the WWWROOT folder of the CLIENT project as follows

Between the HEAD tags add:
```html
<link href="_content/BlazorKit.Spinners/spinners.css" rel="stylesheet" />
<link href="_content/BlazorKit.Spinners/keyframes.css" rel="stylesheet" />
```

Between the BODY tags edit the APP section so that it looks like this:
```Razor
<div id="app">
  <div class="loaderWrapper">
    <span class="loaderMain"></span>
  </div>
</div>
```

### Razor

```Razor
<SpinnerLoader IsLoading="isLoading" HasError="hasError" Size="46px" AccentColor="#3498db" Color="White" Center="true" Spinner="SpinnerTemplate.Loader1">
    <ContentTemplate>
        <table class="table">
            ...
        </table>
    </ContentTemplate>
    <ErrorContentTemplate>
        <tr>
            <td colspan="4">
                <div class="alert alert-danger">Fail</div>
            </td>
        </tr>
    </ErrorContentTemplate>
</SpinnerLoader>
```

### Code Behind

```CSharp
    private bool hasError = false;
    private bool isLoading = true;

    protected override async Task OnInitializedAsync()
    {
        isLoading = true;
        await Task.Delay(5000);
        try
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
        catch (Exception)
        {
            hasError = true;
        }
        finally
        {
            isLoading = false;
        }
    }
```
