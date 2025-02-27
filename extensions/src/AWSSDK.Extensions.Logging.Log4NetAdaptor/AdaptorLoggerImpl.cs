/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */
using Amazon.Runtime.Logging;
using log4net;
using System;

namespace Amazon.Extensions.Logging.Log4NetAdaptor
{
    internal class AdaptorLoggerImpl : IAdaptorLogger
    {
        private ILog _logger;

        internal AdaptorLoggerImpl(ILog logger)
        {
            _logger = logger;
        }

        public bool IsEnabled(SdkLogLevel level)
        {
            switch (level)
            {
                case SdkLogLevel.Trace: // Log4net does not have a Trace level logging so grouping with Debug
                case SdkLogLevel.Debug:
                    return _logger.IsDebugEnabled;
                case SdkLogLevel.Info:
                    return _logger.IsInfoEnabled;
                case SdkLogLevel.Warn:
                    return _logger.IsWarnEnabled;
                case SdkLogLevel.Error:
                    return _logger.IsErrorEnabled;
                case SdkLogLevel.Fatal:
                    return _logger.IsFatalEnabled;
                default:
                    return _logger.IsInfoEnabled; // If the SDK ever adds a new log level that the adaptor doesn't know about default to INFO log level
            }
        }

        public void Log(SdkLogLevel level, string message, Exception ex, params object[] parameters)
        {
            switch(level)
            {
                case SdkLogLevel.Trace: // Log4net does not have a Trace level logging so grouping with Debug
                case SdkLogLevel.Debug:
                    _logger.DebugFormat(message, parameters);
                    break;
                case SdkLogLevel.Info:
                    _logger.InfoFormat(message, parameters);
                    break;
                case SdkLogLevel.Warn:
                    _logger.WarnFormat(message, parameters);
                    break;
                case SdkLogLevel.Error:
                    _logger.ErrorFormat(message, parameters);
                    break;
                case SdkLogLevel.Fatal:
                    _logger.FatalFormat(message, parameters);
                    break;
                default:
                    _logger.InfoFormat(message, parameters); // If the SDK ever adds a new log level that the adaptor doesn't know about default to INFO log level
                    break;
            }
        }
    }

    internal class AdaptorLoggerFactoryImpl : IAdaptorLoggerFactory
    {
        public string Name { get; } = "Log4Net";

        public IAdaptorLogger CreateAdaptorLogger(Type type)
        {
            return new AdaptorLoggerImpl(LogManager.GetLogger(type));
        }
    }
}
