# Installation

NSec is available as [a NuGet package from
nuget.org](https://www.nuget.org/packages/NSec.Cryptography/18.5.0-preview3). It
can be added to a project in a number of ways, depending on the project type and
tools used:


#### dotnet CLI

    $ dotnet add package NSec.Cryptography --version 18.5.0-preview3


#### Visual Studio

    PM> Install-Package NSec.Cryptography -Version 18.5.0-preview3

#### .csproj

    <PackageReference Include="NSec.Cryptography" Version="18.5.0-preview3"/>

!!! Note
    This is a pre-release version of NSec.


## Supported Languages

NSec requires **C# 7.2** or later.

A C# 7.2 compiler is included in the .NET Core SDK beginning with version 2.1
and Visual Studio beginning with version 15.5.
Projects need to opt into C# 7.2 by setting the [Language
Version](https://docs.microsoft.com/en-us/visualstudio/ide/reference/advanced-build-settings-dialog-box-csharp)
to **latest** or **7.2** (or later).


## Supported Platforms

NSec runs on the following platforms and .NET Core versions:

| OS            | Version  | Architectures | .NET Core Runtimes    |
|:------------- |:-------- |:------------- |:--------------------- |
| Windows 10    | 1803     | x64 / x86     | 2.1  /  2.0  /  1.1   |
|               |          |               |                       |
| macOS         | 10.12    | x64           | 2.1  /  2.0  /  1.1   |
|               |          |               |                       |
| CentOS        | 7.4      | x64           | 2.1  /  2.0  /  1.1   |
| Debian        | 8.10     | x64           | 2.1  /  2.0  /  1.1   |
|               | 9.4      | x64           | 2.1  /  2.0           |
| Fedora        | 26       | x64           | 2.1  /  2.0           |
|               | 27       | x64           | 2.1  /  2.0           |
|               | 28       | x64           | 2.1  /  2.0           |
| OpenSUSE      | 42.3     | x64           | 2.1  /  2.0           |
| Ubuntu        | 14.04    | x64           | 2.1  /  2.0  /  1.1   |
|               | 16.04    | x64           | 2.1  /  2.0  /  1.1   |
|               | 17.10    | x64           | 2.1  /  2.0           |
|               | 18.04    | x64           | 2.1  /  2.0           |

Other operating systems and versions supported by .NET Core should work as
well but are untested.

Using NSec on Windows requires the [Visual C++ 2015
Redistributable](https://www.microsoft.com/en-us/download/details.aspx?id=53587).
This dependency is automatically installed by the .NET Core installer but may
not be present, for example, when deploying a self-contained application.

The implementation of AES-GCM in NSec is hardware-accelerated and requires a
processor with the Intel SSSE3, AES-NI, and CLMUL extensions. The availability
of these extensions can be checked at runtime using the static `IsSupported`
property of the `NSec.Cryptography.Aes256Gcm` class.


### .NET Framework

Running NSec on recent versions of .NET Framework might work as well but is
untested. It seems at least the following conditions are required to be met:
First, the project needs to use [*<PackageReference>* package
references](https://blog.nuget.org/20170316/NuGet-now-fully-integrated-into-MSBuild.html#what-about-other-project-types-that-are-not-net-core);
projects using *Packages.config* don't work. Second, the project needs to have
the [Platform
Target](https://docs.microsoft.com/en-us/visualstudio/ide/reference/build-page-project-designer-csharp)
set to **x64** or **x86**; other platform targets -- including *Any CPU* --
don't work.
