/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.Util;
using System;
using System.Globalization;
using System.IO;
using System.Threading;

namespace Amazon.Runtime.Logging
{
    /// <summary>
    /// Adaptor for outputing the SDK logs to the console.
    /// </summary>
    internal class ConsoleAdaptorLogger : IAdaptorLogger
    {
        public static long _sequenceId;

        private Type _declaredLoggerType;

        public bool IsEnabled(SdkLogLevel level) => true;

        public ConsoleAdaptorLogger(Type declaredLoggerType)
        {
            _declaredLoggerType = declaredLoggerType;
        }

        public void Log(SdkLogLevel level, string message, Exception ex, params object[] parameters)
        {
            var formatted = string.Format(CultureInfo.CurrentCulture, message, parameters);
            string logMessage;

            long sequence = Interlocked.Increment(ref _sequenceId);
            string dt = AWSSDKUtils.CorrectedUtcNow.ToString(AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture);
            string asString = level.ToString().ToUpper(CultureInfo.InvariantCulture);

            if (ex != null)
                logMessage = string.Format(CultureInfo.CurrentCulture, "{0}|{1}|{2}|{3} --> {4}", sequence, dt, asString, formatted, ex.ToString());
            else
                logMessage = string.Format(CultureInfo.CurrentCulture, "{0}|{1}|{2}|{3}", sequence, dt, asString, formatted);

            Console.WriteLine(@"{0} {1}", _declaredLoggerType.Name, logMessage);
        }
    }

    internal class ConsoleAdaptorLoggerFactory : IAdaptorLoggerFactory
    {
        public string Name { get; } = "Console";

        public IAdaptorLogger CreateAdaptorLogger(Type type)
        {
            return new ConsoleAdaptorLogger(type);
        }
    }
}
