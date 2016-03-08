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
using System.Linq;
using System.Text;

namespace Amazon.Runtime.Internal.Util
{
    internal class UnityDebugLogger : InternalLogger
    {

        public UnityDebugLogger(Type declaringType)
            : base(declaringType)
        {
        }

        public override void Flush()
        {
            //flush not supported on unity debug logger
        }

        public override void Error(Exception exception, string messageFormat, params object[] args)
        {
            if (exception != null)
                UnityEngine.Debug.LogException(exception);

            if (!string.IsNullOrEmpty(messageFormat))
                UnityEngine.Debug.LogError(string.Format(messageFormat, args));
        }

        public override void Debug(Exception exception, string messageFormat, params object[] args)
        {
            if (exception != null)
                UnityEngine.Debug.LogException(exception);

            if (!string.IsNullOrEmpty(messageFormat))
                UnityEngine.Debug.Log(string.Format(messageFormat, args));
        }

        public override void DebugFormat(string messageFormat, params object[] args)
        {
            if (!string.IsNullOrEmpty(messageFormat))
                UnityEngine.Debug.Log(string.Format(messageFormat, args));
        }

        public override void InfoFormat(string message, params object[] arguments)
        {
            if (!string.IsNullOrEmpty(message))
                UnityEngine.Debug.Log(string.Format(message, arguments));
        }

        public override bool IsDebugEnabled { get { return true; } }
        //always enable error
        public override bool IsErrorEnabled { get { return true; } }

        public override bool IsInfoEnabled { get { return true; } }


    }
}
