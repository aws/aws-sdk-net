/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Specialized;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.ComponentModel;

using Amazon.Util.Internal;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Logger for writing to the console window
    /// </summary>
    internal class InternalConsoleLogger : InternalLogger
    {
        private object internalLogger;

        public InternalConsoleLogger(Type declaringType)
            : base(declaringType)
        {
        }

        #region Overrides

        public override void Flush()
        {
        }


        /// <summary>
        /// Write to the console window.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public override void Error(Exception exception, string messageFormat, params object[] args)
        {
            Console.Error.WriteLine(messageFormat, args);
            if (exception != null)
            {
                Console.Error.WriteLine("Exception Message: " + exception.Message);
                Console.Error.WriteLine(exception.StackTrace);
            }
        }

        /// <summary>
        /// Write to the console window.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public override void Debug(Exception exception, string messageFormat, params object[] args)
        {
            Console.Error.WriteLine(messageFormat, args);
            if (exception != null)
            {
                Console.WriteLine("Exception Message: " + exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
        }

        /// <summary>
        /// Write to the console window.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public override void DebugFormat(string message, params object[] arguments)
        {
            Console.WriteLine(message, arguments);
        }

        /// <summary>
        /// Write to the console window.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public override void InfoFormat(string message, params object[] arguments)
        {
            Console.WriteLine(message, arguments);
        }

        #endregion
    }

}
