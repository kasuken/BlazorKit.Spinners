
# BlazorKit.Spinners

![](https://countrush-prod.azurewebsites.net/l/badge/?repository=kasuken.BlazorKitSpinners)

A Blazor library for loading spinners.

It's a beta version.

## Screenshots

![App Screenshot](https://github.com/kasuken/BlazorKit.Spinners/raw/dev/blazorkit.spinners.gif)


## Features

- 8 different spinners out-of-the-box
- colors customisation (accent color and background color)
- center the spinner with a property
- easy implementation on your code
- custom main spinner for web assembly loading


## Roadmap

- Additional spinners
- More than 30 spinners
- .NET 6 migration


## Installation

With Package Manager:

```
Install-Package BlazorKit.Spinners
```

With .NET CLI:

```
dotnet add package BlazorKit.Spinners
```

If the project is Blazor WebAssembly, it is also necessary to modify the INDEX.HTML page present in the WWWROOT folder of the CLIENT project as follows

Between the HEAD tags add:
```
<link href="_content/BlazorKit.Spinners/spinners.css" rel="stylesheet" />
<link href="_content/BlazorKit.Spinners/keyframes.css" rel="stylesheet" />
```

Between the BODY tags edit the APP section so that it looks like this:
```
<div id="app">
  <div class="loaderWrapper">
    <span class="loaderMain"></span>
  </div>
</div>
```

## Tech Stack

- Blazor
- .NET 5

## Run Locally

Clone the project

```bash
  git clone https://github.com/kasuken/BlazorKit.Spinners
```

Go to the project directory

```bash
  cd BlazorKit.Spinners
```

Start

```bash
  dotnet run
```


## Contributing

Contributions are always welcome!

## Inspired by

https://codepen.io/vineethtrv/pen/NWxZqMM
