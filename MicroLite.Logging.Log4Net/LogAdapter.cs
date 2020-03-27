// -----------------------------------------------------------------------
// <copyright file="LogAdapter.cs" company="Project Contributors">
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
using System.Globalization;

namespace MicroLite.Logging.Log4Net
{
    internal sealed class LogAdapter : ILog
    {
        private readonly log4net.ILog _log;

        internal LogAdapter(log4net.ILog log) => _log = log;

        public bool IsDebug => _log.IsDebugEnabled;

        public bool IsError => _log.IsErrorEnabled;

        public bool IsFatal => _log.IsFatalEnabled;

        public bool IsInfo => _log.IsInfoEnabled;

        public bool IsWarn => _log.IsWarnEnabled;

        public void Debug(string message) => _log.Debug(message);

        public void Debug(string message, params string[] formatArgs) => _log.DebugFormat(CultureInfo.InvariantCulture, message, formatArgs);

        public void Error(string message) => _log.Error(message);

        public void Error(string message, params string[] formatArgs) => _log.ErrorFormat(CultureInfo.InvariantCulture, message, formatArgs);

        public void Error(string message, Exception exception) => _log.Error(message, exception);

        public void Fatal(string message) => _log.Fatal(message);

        public void Fatal(string message, params string[] formatArgs) => _log.FatalFormat(CultureInfo.InvariantCulture, message, formatArgs);

        public void Fatal(string message, Exception exception) => _log.Fatal(message, exception);

        public void Info(string message) => _log.Info(message);

        public void Info(string message, params string[] formatArgs) => _log.InfoFormat(CultureInfo.InvariantCulture, message, formatArgs);

        public void Warn(string message) => _log.Warn(message);

        public void Warn(string message, params string[] formatArgs) => _log.WarnFormat(CultureInfo.InvariantCulture, message, formatArgs);
    }
}
