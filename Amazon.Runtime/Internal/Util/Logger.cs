/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// This is a dynamic wrapper around log4net so we can avoid log4net being required
    /// to be distributed with the SDK.
    /// </summary>
    internal class Logger
    {
        enum LoadState { Uninitialized, Failed, Loading, Success };

        #region Reflected Types and methods
        static LoadState loadState = LoadState.Uninitialized;
        static readonly object LOCK = new object();

        static Type logMangerType;
        static MethodInfo getLoggerWithTypeMethod;

        static Type logType;
        static MethodInfo debugFormatMethod;
        static MethodInfo debugWithExceptionMethod;
        static MethodInfo errorWithExceptionMethod;
        static MethodInfo infoFormatMethod;
        #endregion

        object internalLogger;

        public Logger(Type type)
        {
            if (loadState == LoadState.Uninitialized)
            {
                loadStatics();
            }

            if (logMangerType == null)
                return;

            this.internalLogger = getLoggerWithTypeMethod.Invoke(null, new object[] { type });
        }

        /// <summary>
        /// This should be a one time call to use reflection to find all the types and methods
        /// needed for the logging API.
        /// </summary>
        private static void loadStatics()
        {
            lock (Logger.LOCK)
            {
                if (loadState != LoadState.Uninitialized)
                    return;

                loadState = LoadState.Loading;
                try
                {
                    // The LogManager and its methods
                    logMangerType = Type.GetType("log4net.LogManager, log4net");
                    if (logMangerType == null)
                    {
                        loadState = LoadState.Failed;
                        return;
                    }
                    getLoggerWithTypeMethod = logMangerType.GetMethod("GetLogger", new Type[] { typeof(Type) });

                    // The ILog and its methdods
                    logType = Type.GetType("log4net.ILog, log4net");
                    debugFormatMethod = logType.GetMethod("DebugFormat", new Type[] { typeof(string), typeof(object[]) });
                    debugWithExceptionMethod = logType.GetMethod("Debug", new Type[] { typeof(string), typeof(Exception) });
                    errorWithExceptionMethod = logType.GetMethod("Error", new Type[] { typeof(string), typeof(Exception) });
                    infoFormatMethod = logType.GetMethod("InfoFormat", new Type[] { typeof(string), typeof(object[]) });

                    if (getLoggerWithTypeMethod == null ||
                        logType == null ||
                        debugFormatMethod == null ||
                        debugWithExceptionMethod == null ||
                        errorWithExceptionMethod == null ||
                        infoFormatMethod == null)
                    {
                        loadState = LoadState.Failed;
                        return;
                    }

                    loadState = LoadState.Success;
                }
                catch
                {
                    // Mark as failed so no attempted will be made on the logging methods.
                    loadState = LoadState.Failed;
                }
            }
        }

        /// <summary>
        /// Simple wrapper around the log4net Error method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void Error(string message, Exception exception)
        {
            if (loadState != LoadState.Success || this.internalLogger == null || errorWithExceptionMethod == null)
                return;

            errorWithExceptionMethod.Invoke(this.internalLogger, new object[] { message, exception });
        }

        /// <summary>
        /// Simple wrapper around the log4net Debug method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void Debug(string message, Exception exception)
        {
            if (loadState != LoadState.Success || this.internalLogger == null || debugWithExceptionMethod == null)
                return;

            debugWithExceptionMethod.Invoke(this.internalLogger, new object[] { message, exception });
        }

        /// <summary>
        /// Simple wrapper around the log4net DebugFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public void DebugFormat(string message, params object[] arguments)
        {
            if (loadState != LoadState.Success || this.internalLogger == null || debugFormatMethod == null)
                return;

            debugFormatMethod.Invoke(this.internalLogger, new object[] { message, arguments });
        }

        /// <summary>
        /// Simple wrapper around the log4net InfoFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public void InfoFormat(string message, params object[] arguments)
        {
            if (loadState != LoadState.Success || this.internalLogger == null || infoFormatMethod == null)
                return;

            infoFormatMethod.Invoke(this.internalLogger, new object[] { message, arguments });
        }
    }
}
