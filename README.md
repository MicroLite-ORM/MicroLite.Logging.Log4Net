MicroLite.Logging.Log4Net
=========================

[![NuGet version](https://badge.fury.io/nu/MicroLite.Logging.Log4Net.svg)](http://badge.fury.io/nu/MicroLite.Logging.Log4Net)

_MicroLite.Logging.Log4Net_ is an extension to the MicroLite ORM Framework which allows MicroLite to write any log statements to [log4net](http://logging.apache.org/log4net/).

In order to use the extension, you first need to install it via NuGet:

    Install-Package MicroLite.Logging.Log4Net

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

## Supported .NET Framework Versions

The NuGet Package contains binaries compiled against:

* .NET 3.5 (Client Profile)
* .NET 4.0 (Client Profile)
* .NET 4.5

## Supported log4net Versions

* log4net 2.0.0 (1.2.11) onwards
