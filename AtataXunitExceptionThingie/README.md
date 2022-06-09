# About

This simple project reproduces a strange Nunit-related exception that occurs when referencing `Atata.Configuration.Json` nuget package in a Atata-testing project built to use Xunit instead of Nunit.

At line 23 of the `SimpleUiTestsFixture` class, this exception (with an error message referencing Nunit) occurs even though there are no Nunit nuget packages installed:

```
An exception of type 'System.IO.FileNotFoundException' occurred in System.Private.CoreLib.dll but was not handled in user code. Could not load file or assembly 'nunit.framework, Culture=neutral, PublicKeyToken=null'. The system cannot find the file specified.
```

Debug the `SampleTests.SampleTest` test method to reproduce the error.

NOTE: If VS doesn't break on the exception, ensure that breaking on the **FileNotFoundException** is enabled under Debug -> Exception Settings (go the `Debug` menu, `Windows` -> `Exception Settings`, then hit `CTRL+E` and enter 'FileNotFoundException' to filter for its specific checkbox setting).

## Test environment info

- Microsoft Visual Studio Professional 2022
	* Version 17.1.6

- Microsoft .NET Framework
	* Version 4.8.04084

- Windows 10 Enterprise
	* Version	20H2
	* OS build	19042.1645

### Packages references list

```XML
<PackageReference Include="Atata" Version="2.0.1" />
<PackageReference Include="Atata.Configuration.Json" Version="2.0.0" />
<PackageReference Include="Atata.WebDriverSetup" Version="2.1.0" />
<PackageReference Include="Microsoft.Extensions.Configuration.EnvironmentVariables" Version="3.1.25" />
<PackageReference Include="Microsoft.Extensions.Configuration.Xml" Version="3.1.25" />
<PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.2.0" />
<PackageReference Include="xunit.core" Version="2.4.1" />
<PackageReference Include="xunit.runner.visualstudio" Version="2.4.5">
```