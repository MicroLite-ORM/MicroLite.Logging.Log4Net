// -----------------------------------------------------------------------
// <copyright file="LogAdapter.cs" company="Project Contributors">
// Copyright 2012 - 2018 Project Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// </copyright>
// -----------------------------------------------------------------------
namespace MicroLite.Logging.Log4Net
{
    using System;
    using System.Globalization;

    internal sealed class LogAdapter : ILog
    {
        private readonly log4net.ILog log;

        internal LogAdapter(log4net.ILog log)
        {
            this.log = log;
        }

        public bool IsDebug => this.log.IsDebugEnabled;

        public bool IsError => this.log.IsErrorEnabled;

        public bool IsFatal => this.log.IsFatalEnabled;

        public bool IsInfo => this.log.IsInfoEnabled;

        public bool IsWarn => this.log.IsWarnEnabled;

        public void Debug(string message) => this.log.Debug(message);

        public void Debug(string message, params string[] formatArgs) => this.log.DebugFormat(CultureInfo.InvariantCulture, message, formatArgs);

        public void Error(string message) => this.log.Error(message);

        public void Error(string message, params string[] formatArgs) => this.log.ErrorFormat(CultureInfo.InvariantCulture, message, formatArgs);

        public void Error(string message, Exception exception) => this.log.Error(message, exception);

        public void Fatal(string message) => this.log.Fatal(message);

        public void Fatal(string message, params string[] formatArgs) => this.log.FatalFormat(CultureInfo.InvariantCulture, message, formatArgs);

        public void Fatal(string message, Exception exception) => this.log.Fatal(message, exception);

        public void Info(string message) => this.log.Info(message);

        public void Info(string message, params string[] formatArgs) => this.log.InfoFormat(CultureInfo.InvariantCulture, message, formatArgs);

        public void Warn(string message) => this.log.Warn(message);

        public void Warn(string message, params string[] formatArgs) => this.log.WarnFormat(CultureInfo.InvariantCulture, message, formatArgs);
    }
}