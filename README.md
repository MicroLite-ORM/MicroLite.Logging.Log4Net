MicroLite.Logging.Log4Net
=========================

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

_Supported .NET Framework Versions_

The NuGet Package contains binaries compiled against 3.5, 4.0 and 4.5.