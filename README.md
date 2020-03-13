MicroLite.Logging.Log4Net
=========================

|Service|Status|
|-------|------|
||[![NuGet version](https://badge.fury.io/nu/MicroLite.Logging.Log4Net.svg)](http://badge.fury.io/nu/MicroLite.Logging.Log4Net)|
|/develop|[![Build Status](https://dev.azure.com/trevorpilley/MicroLite-ORM/_apis/build/status/MicroLite-ORM.MicroLite.Logging.Log4Net?branchName=develop)](https://dev.azure.com/trevorpilley/MicroLite-ORM/_build/latest?definitionId=33&branchName=develop)|
|/master|[![Build Status](https://dev.azure.com/trevorpilley/MicroLite-ORM/_apis/build/status/MicroLite-ORM.MicroLite.Logging.Log4Net?branchName=master)](https://dev.azure.com/trevorpilley/MicroLite-ORM/_build/latest?definitionId=33&branchName=master)|

MicroLite.Logging.Log4Net is a .NET 4.5 library which adds an extension for the MicroLite ORM Framework to use log4net as the logging library.

## Installation

Install the nuget package `Install-Package MicroLite.Extensions.Log4Net`

## Configuration

You can then load the extension in your application start-up:

    // Configure log4net first, MicroLite.Logging.Log4Net assumes it has already been configured.
    log4net.Config.XmlConfigurator.Configure();

    // Load the extensions for MicroLite
    Configure
       .Extensions()
       .WithLog4Net();

    // Create the session factory...
    Configure
       .Fluently()
       ...

For further information on configuring log4net, see [logging.apache.org/log4net/release/config-examples.html](http://logging.apache.org/log4net/release/config-examples.html).

## Supported .NET Versions

The NuGet Package contains binaries compiled against (dependencies indented):

* .NET Framework 4.5
  * MicroLite 7.0.0
  * log4net 2.0.8
