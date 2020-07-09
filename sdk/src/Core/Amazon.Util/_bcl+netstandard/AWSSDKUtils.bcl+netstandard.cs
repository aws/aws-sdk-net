/*******************************************************************************
 *  Copyright 2008-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime.Internal.Util;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Threading;
#if AWS_ASYNC_API
using System.Threading.Tasks;
#endif

namespace Amazon.Util
{
    public static partial class AWSSDKUtils
    {
#region Internal Constants
        private const int MaxIsSetMethodsCacheSize = 50;
#endregion

#region Private Methods, Static Fields and Classes

#if !NETSTANDARD13
        private static LruCache<IsSetMethodsCacheKey, MethodInfo> IsSetMethodsCache = new LruCache<IsSetMethodsCacheKey, MethodInfo>(MaxIsSetMethodsCacheSize);

        private class IsSetMethodsCacheKey
        {
            public readonly Type Type;
            public readonly string PropertyName;
            public IsSetMethodsCacheKey(Type type, string propertyName)
            {
                Type = type;
                PropertyName = propertyName;
            }
            public override bool Equals(object other)
            {
                var otherKey = other as IsSetMethodsCacheKey;
                if (otherKey == null)
                {
                    return false;
                }
                return Type == otherKey.Type && PropertyName == otherKey.PropertyName;
            }

            public override int GetHashCode()
            {
                return Type.GetHashCode() ^ PropertyName.GetHashCode();
            }

            public override string ToString()
            {
                return Type.FullName + "." + PropertyName;
            }
        }
#endif
#endregion

#region Public Methods and Properties
        /// <summary>
        /// Runs a process with the below input parameters.
        /// </summary>
        /// <param name="processStartInfo"></param>
        /// <returns></returns>
        [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
        public static ProcessExecutionResult RunProcess(ProcessStartInfo processStartInfo)
        {
            using (var process = new Process
            {
                StartInfo = processStartInfo
            })
            {
                var logger = Logger.GetLogger(typeof(AWSSDKUtils));
                logger.InfoFormat("Starting a process with the following ProcessInfo: UseShellExecute - {0} RedirectStandardError - {1}, RedirectStandardOutput - {2}, CreateNoWindow - {3}",  
                    processStartInfo.UseShellExecute, processStartInfo.RedirectStandardError, processStartInfo.RedirectStandardOutput, processStartInfo.CreateNoWindow);
                process.Start();
                logger.InfoFormat("Process started");
                string standardOutput = null;
                var thread = new Thread(() => standardOutput = process.StandardOutput.ReadToEnd());
                thread.Start();
                var standardError = process.StandardError.ReadToEnd();
                thread.Join();
                process.WaitForExit();                

                return new ProcessExecutionResult
                {
                    ExitCode = process.ExitCode,
                    StandardError = standardError,
                    StandardOutput = standardOutput
                };                
            }
        }
#if AWS_ASYNC_API
        [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
        public static async Task<ProcessExecutionResult> RunProcessAsync(ProcessStartInfo processStartInfo)
        {
            var logger = Logger.GetLogger(typeof(AWSSDKUtils));
            using (var process = new Process
            {
                StartInfo = processStartInfo,
                EnableRaisingEvents = true
            })
            {
                var tcs = new TaskCompletionSource<object>();
                process.Exited += (s, ea) => tcs.SetResult(null);
                logger.InfoFormat("Starting a process with the following ProcessInfo: UseShellExecute - {0} RedirectStandardError - {1}, RedirectStandardOutput - {2}, CreateNoWindow - {3}",  
                    processStartInfo.UseShellExecute, processStartInfo.RedirectStandardError, processStartInfo.RedirectStandardOutput, processStartInfo.CreateNoWindow);                
                process.Start();
                logger.InfoFormat("Process started");

                var standardErrorTask = process.StandardError.ReadToEndAsync();
                var standardOutputTask = process.StandardOutput.ReadToEndAsync();

                await Task.WhenAll(tcs.Task, standardErrorTask, standardOutputTask).ConfigureAwait(false);

                return new ProcessExecutionResult
                {
                    ExitCode = process.ExitCode,
                    StandardError = standardErrorTask.Result,
                    StandardOutput = standardOutputTask.Result
                };
            }

        }
#endif

#if !NETSTANDARD13
        /// <summary>
        /// This method allows to check whether a property of an object returned by a service call
        /// is set. This method is needed to discriminate whether a field is not set (not present in
        /// the service response) or if it is set to the default value for its type. Using this
        /// method is not required for nullable properties (non-ValueType and Nullable) because
        /// they will be simply set to null when not included in the service response.
        /// This method can also be used on objects used as part of service requests.
        /// This method doesn't support objects that are part of the S3 service model.
        /// </summary>
        /// <param name="awsServiceObject">An object that is used in an AWS service request or is
        /// returned as part of an AWS service response.</param>
        /// <param name="propertyName">The name of the property of awsServiceObject to check.</param>
        /// <returns>True if the property is set, otherwise false.</returns>
        public static bool IsPropertySet(object awsServiceObject, string propertyName)
        {
            var type = awsServiceObject.GetType();
            var nameSpace = type.Namespace;

            if (!nameSpace.StartsWith("Amazon.", StringComparison.Ordinal) || !nameSpace.EndsWith(".Model", StringComparison.Ordinal))
            {
                throw new ArgumentException("IsPropertySet can be used only on Amazon Model classes");
            }
            else if (nameSpace == "Amazon.S3.Model")
            {
                throw new ArgumentException("IsPropertySet doesn't support S3");
            }

            var key = new IsSetMethodsCacheKey(type, propertyName);

            //We cache the result of GetIsPropertySetMethodInfo even if it is null
            var method = IsSetMethodsCache.GetOrAdd(key, (k) => k.Type.GetMethod("IsSet" + k.PropertyName,
                                                                                 BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance,
                                                                                 null,
                                                                                 new Type[0],
                                                                                 new ParameterModifier[0]));
            if (method == null)
            {
                throw new ArgumentException("Could not find an IsSet method for property " + key);
            }

            object result = method.Invoke(awsServiceObject, new object[0]);

            if (!(result is bool))
            {
                throw new ArgumentException("The IsSet method for property " + key + " didn't return a bool");
            }

            return (bool)result;
        }
#endif
#endregion
    }
}
