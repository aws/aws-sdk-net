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
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
    public static class AsyncRunner
    {
        public static Task Run(Action action, CancellationToken cancellationToken)
        {
            return Run<object>(() =>
            {
                action();
                return null;
            }, cancellationToken);
        }

        public static Task<T> Run<T>(Func<T> action, CancellationToken cancellationToken)
        {
#if PCL
            Task<T> task = Task.Run<T>(action);
            return task;
#else
            return Task<T>.Run(() =>
            {
                Exception exception = null;
                T result = default(T);
                Thread thread = new Thread(() =>
                {
                    try
                    {
                        result = action();
                    }
                    catch (Exception e)
                    {
                        exception = e;
                    }
                });
                using (var ctr = cancellationToken.Register(() =>
                {
                    if (thread.IsAlive)
                        thread.Abort();
                }))
                {
                    thread.Start();
                    thread.Join();

                    if (exception != null)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(exception).Throw();
                    }

                    return result;
                }
            }, cancellationToken);
#endif
        }
    }
}
