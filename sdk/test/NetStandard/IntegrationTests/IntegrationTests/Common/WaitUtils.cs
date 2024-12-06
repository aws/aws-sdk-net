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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.DNXCore.IntegrationTests.Common
{
    public class WaitUtils
    {
        public static readonly TimeSpan DefaultMaxWaitTime = TimeSpan.FromMinutes(2);
        public static readonly TimeSpan DefaultSleepTime = TimeSpan.FromSeconds(10);

        public static T WaitForComplete<T>(Func<T> func)
        {
            return WaitForComplete(func, (r) => { return true; }, DefaultMaxWaitTime, DefaultSleepTime);
        }

        public static T WaitForComplete<T>(Func<T> func, Func<T, bool> isComplete)
        {
            return WaitForComplete(func, isComplete, DefaultMaxWaitTime, DefaultSleepTime);
        }

        public static T WaitForComplete<T>(Func<T> func, Func<T, bool> isComplete, int maxWaitSeconds, int sleepSeconds)
        {
            return WaitForComplete(func, isComplete, TimeSpan.FromSeconds(maxWaitSeconds), TimeSpan.FromSeconds(sleepSeconds));
        }

        public static T WaitForComplete<T>(Func<T> func, Func<T, bool> isComplete, TimeSpan maxWaitTime, TimeSpan sleepTime)
        {
            var stopTime = DateTime.UtcNow + maxWaitTime;
            Exception lastException = null;
            var success = false;
            while (DateTime.UtcNow < stopTime)
            {
                try
                {
                    var result = func.Invoke();
                    if (isComplete.Invoke(result))
                    {
                        success = true;
                        return result;
                    }
                }
                catch (Exception e)
                {
                    lastException = e;
                }
                finally
                {
                    if (!success)
                        UtilityMethods.Sleep(sleepTime);
                }
            }
            throw lastException ?? new Exception("Condition not met in WaitForComplete.");
        }
    }
}
