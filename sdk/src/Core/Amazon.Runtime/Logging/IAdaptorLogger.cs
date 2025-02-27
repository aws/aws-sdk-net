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
using System;

namespace Amazon.Runtime.Logging
{
    /// <summary>
    /// The adaptor logger that wraps the logger from the targeted logging framework.
    /// </summary>
    public interface IAdaptorLogger
    {
        /// <summary>
        /// True if the log level is enabled.
        /// </summary>
        /// <param name="level"></param>
        /// <returns>True if the log level is enabled.</returns>
        bool IsEnabled(SdkLogLevel level);

        /// <summary>
        /// Send a log message to the wrapped logging framework.
        /// </summary>
        /// <param name="level">Level of the log message.</param>
        /// <param name="message">Message to be logged.</param>
        /// <param name="ex">Exception that should be logged. If no has occurred exception pass null.</param>
        /// <param name="parameters">Parameters to use for formatting the log message.</param>
        void Log(SdkLogLevel level, string message, Exception ex, params object[] parameters);
    }

    /// <summary>
    /// Factory for creating a logger that wraps the logging framework.
    /// </summary>
    public interface IAdaptorLoggerFactory
    {
        /// <summary>
        /// The name of the factory used to store the factory in the registry.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Creates a logger.
        /// </summary>
        /// <param name="type"></param>
        /// <returns>The IAdaptorLogger wrapping the adapted logging framework's logger.</returns>
        IAdaptorLogger CreateAdaptorLogger(Type type);
    }
}
