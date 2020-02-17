// -----------------------------------------------------------------------
// <copyright file="Log4NetConfigurationExtensions.cs" company="Project Contributors">
// Copyright Project Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// </copyright>
// -----------------------------------------------------------------------
using System;
using MicroLite.Logging.Log4Net;

namespace MicroLite.Configuration
{
    /// <summary>
    /// Extensions for the MicroLite configuration.
    /// </summary>
    public static class Log4NetConfigurationExtensions
    {
        /// <summary>
        /// Configures the MicroLite ORM Framework to use log4net as the logging framework.
        /// </summary>
        /// <param name="configureExtensions">The interface to configure extensions.</param>
        /// <returns>The configure extensions.</returns>
        public static IConfigureExtensions WithLog4Net(this IConfigureExtensions configureExtensions)
        {
            if (configureExtensions is null)
            {
                throw new ArgumentNullException(nameof(configureExtensions));
            }

            System.Diagnostics.Trace.TraceInformation("MicroLite: loading log4net extension.");

            configureExtensions.SetLogResolver((Type type) =>
            {
                log4net.ILog logger = log4net.LogManager.GetLogger(type.FullName);

                return new LogAdapter(logger);
            });

            if (!log4net.LogManager.GetRepository().Configured)
            {
                System.Diagnostics.Trace.TraceWarning("MicroLite: log4net has not yet been configured, until it has been; no logging will occur.");
            }

            System.Diagnostics.Trace.TraceInformation("MicroLite: log4net extension loaded.");

            return configureExtensions;
        }
    }
}
