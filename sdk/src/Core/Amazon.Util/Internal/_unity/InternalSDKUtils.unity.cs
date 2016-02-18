/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 */
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;
using System.Reflection;
using System.Threading;
using UnityEngine;
using System.Threading;
using Logger = Amazon.Runtime.Internal.Util.Logger;

namespace Amazon.Util.Internal
{
    public static partial class InternalSDKUtils
    {
        static string _userAgentBaseName = "aws-sdk-unity";
		
        private const string UnknownMonoVersion = "Mono/Unknown";
		
        public static string GetMonoRuntimeVersion()
        {
            Type type = Type.GetType("Mono.Runtime");
            if (type != null)
            {
                MethodInfo displayName = type.GetMethod("GetDisplayName");
                if (displayName != null)
                {
                    var version = (string)displayName.Invoke(null, null);
                    // Replace "/" from the version string as it's a
                    // seperator in the user agent format
                    version = version.Replace("/", ":").Replace(" ",string.Empty);
                    return "Mono/" + version;
                }
            }
            return UnknownMonoVersion;
        }

        public static bool IsAndroid
        {
            get
            {
                return Application.platform == RuntimePlatform.Android;
            }
        }

        public static bool IsiOS
        {
            get
            {
                return Application.platform == RuntimePlatform.IPhonePlayer;
            }
        }


        internal static Type GetTypeFromUnityEngine(string typeName)
        {
            return Type.GetType(string.Format("UnityEngine.{0}, UnityEngine", typeName));
        }

        private static Logger _logger = Logger.GetLogger(typeof(InternalSDKUtils));

        public static void AsyncExecutor(Action action, AsyncOptions options)
        {
            if (options.ExecuteCallbackOnMainThread)
            {
                if (UnityInitializer.IsMainThread())
                {
                    SafeExecute(action);
                }
                else
                {
                    UnityRequestQueue.Instance.ExecuteOnMainThread(action);
                }
            }
            else
            {
                if (!UnityInitializer.IsMainThread())
                {
                    SafeExecute(action);
                }
                else
                {
                    ThreadPool.QueueUserWorkItem((state) =>
                    {
                        SafeExecute(action);
                    });
                }
            }
        }

        public static void SafeExecute(Action action)
        {
            try
            {
                action();
            }
            catch (Exception exception)
            {
                // Catch any unhandled exceptions from the user callback 
                // and log it. 
                _logger.Error(exception,
                    "An unhandled exception was thrown from the callback method {0}.",
                    action.Method.Name);
            }
        }

    }
}
