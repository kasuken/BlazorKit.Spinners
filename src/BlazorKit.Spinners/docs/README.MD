# BlazorKit.Spinners

A Blazor library for loading spinners.

## Screenshots

![App Screenshot](https://github.com/kasuken/BlazorKit.Spinners/raw/dev/blazorkit.spinners.gif)

## Installation

With Package Manager:

```
Install-Package BlazorKit.Spinners
```

With .NET CLI:

```
dotnet add package BlazorKit.Spinners
```

## How to use it

### Razor

```
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

```
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