// -----------------------------------------------------------------------
// <copyright file="Log4NetConfigurationExtensions.cs" company="MicroLite">
// Copyright 2012 - 2014 Project Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// </copyright>
// -----------------------------------------------------------------------
namespace MicroLite.Configuration
{
    using System;
    using MicroLite.Logging.Log4Net;

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
            if (configureExtensions == null)
            {
                throw new ArgumentNullException("configureExtensions");
            }

            System.Diagnostics.Trace.TraceInformation("MicroLite: loading log4net extension.");

            configureExtensions.SetLogResolver((string name) =>
            {
                var logger = log4net.LogManager.GetLogger(name);

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