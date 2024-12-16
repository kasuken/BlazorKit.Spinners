# BlazorKit.Spinners

![](https://countrush-prod.azurewebsites.net/l/badge/?repository=kasuken.BlazorKitSpinners)

[![Publish BlazorKit.Spinners on NuGet](https://github.com/kasuken/BlazorKit.Spinners/actions/workflows/publish.yml/badge.svg?branch=main)](https://github.com/kasuken/BlazorKit.Spinners/actions/workflows/publish.yml)

A Blazor library for loading spinners.

It's a beta version.

## Screenshots

![App Screenshot](https://github.com/kasuken/BlazorKit.Spinners/raw/main/blazorkit.spinners.0.7.14.gif)

## Features

- 8 different spinners out-of-the-box
- colors customisation (accent color and background color)
- center the spinner with a property
- easy implementation on your code
- custom main spinner for web assembly loading

## Roadmap

- [ ] Additional spinners
- [ ] More than 30 spinners
- [ ] .NET 9 migration
- [ ] .NET 8 migration
- [x] .NET 7 migration
- [x] .NET 6 migration

## Installation

With Package Manager:

```gitattributes
Install-Package BlazorKit.Spinners
```

With .NET CLI:

```gitattributes
dotnet add package BlazorKit.Spinners
```

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

## Tech Stack

- Blazor
- .NET 6
- C# 10.0

## Run Locally

Clone the project

```gitattributes
  git clone https://github.com/kasuken/BlazorKit.Spinners
```

Go to the project directory

```gitattributes
  cd BlazorKit.Spinners
```

Start

```gitattributes
  dotnet run
```

## Contributing

Contributions are always welcome!

## Inspired by

https://codepen.io/vineethtrv/pen/NWxZqMM
