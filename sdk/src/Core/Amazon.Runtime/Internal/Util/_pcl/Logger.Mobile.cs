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

#if __IOS__ || __ANDROID__
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
    /// Logger wrapper for Console.WriteLine()
    /// </summary>
    [Obsolete("Use InternalConsoleLogger instead")]
    internal class MobileLogger : InternalLogger
    {
        private const string InfoMsg = "[AWSSDK INFO] {0}";
        private const string DebugMsg = "[AWSSDK DEBUG] {0}";
        private const string ErrorMsg = "[AWSSDK ERROR] {0}";


        public MobileLogger(Type declaringType)
            : base(declaringType)
        {
        }

        #region Overrides

        public override void Flush()
        {
            Console.Out.Flush();
        }

        /// <summary>
        /// Simple wrapper around the log4net IsErrorEnabled property.
        /// </summary>
        public override bool IsErrorEnabled
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Simple wrapper around the log4net Error method.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public override void Error(Exception exception, string messageFormat, params object[] args)
        {
            LogMessage msg = new LogMessage(CultureInfo.InvariantCulture, messageFormat, args);
#if __ANDROID__
            Android.Util.Log.Error(DeclaringType.Name, msg.ToString());
            if (exception != null)
            {
                Android.Util.Log.Error(DeclaringType.Name, exception.ToString());
            }
#else
            Console.WriteLine(string.Format(DebugMsg, "Exception is: " + exception.ToString() + " Message is: " +msg.ToString()));
#endif
        }

        /// <summary>
        /// Simple wrapper around the log4net IsDebugEnabled property.
        /// </summary>
        public override bool IsDebugEnabled
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Simple wrapper around the log4net Debug method.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public override void Debug(Exception exception, string messageFormat, params object[] args)
        {
            LogMessage msg = new LogMessage(CultureInfo.InvariantCulture, messageFormat, args);
#if __ANDROID__
            Android.Util.Log.Debug(DeclaringType.Name, msg.ToString());
            if (exception != null)
            {
                Android.Util.Log.Debug(DeclaringType.Name, exception.ToString());
            }
#else
            Console.WriteLine(string.Format(DebugMsg, "Exception is: " + exception.ToString() + " Message is: " +msg.ToString()));
#endif
        }

        /// <summary>
        /// Simple wrapper around the log4net DebugFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public override void DebugFormat(string message, params object[] arguments)
        {
            LogMessage msg = new LogMessage(CultureInfo.InvariantCulture, message, arguments);
#if __ANDROID__
            Android.Util.Log.Error(DeclaringType.Name, msg.ToString());
#else
            Console.WriteLine(string.Format(DebugMsg, " Message is: " + msg.ToString()));
#endif
        }

        /// <summary>
        /// Simple wrapper around the log4net IsInfoEnabled property.
        /// </summary>
        public override bool IsInfoEnabled
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Simple wrapper around the log4net InfoFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public override void InfoFormat(string message, params object[] arguments)
        {
            LogMessage msg = new LogMessage(CultureInfo.InvariantCulture, message, arguments);
#if __ANDROID__
            Android.Util.Log.Info(DeclaringType.Name, msg.ToString());
#else
            Console.WriteLine(string.Format(InfoMsg, " Message is: " + msg.ToString()));
#endif
        }

        #endregion
    }

}
#endif