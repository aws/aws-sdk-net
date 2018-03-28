﻿/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Threading;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Throttles the number of requests that can be queued to the
    /// .NET thread pool. If the limit is exceeded, subsequent 
    /// requests are stored in an internal queue, till they can be 
    /// enqueued to the thread pool.
    /// </summary>
    public class ThreadPoolThrottler<T>
    {
        private static object _queueLock = new object();

        private int _requestCount = 0;

        private Queue<ThreadPoolOptions<T>> _queuedRequests = new Queue<ThreadPoolOptions<T>>();

        private bool IsWebGL 
        {
            get 
            {
                return UnityEngine.Application.platform == UnityEngine.RuntimePlatform.WebGLPlayer;
            }
        }

        /// <summary>
        /// Maximum number of requests to be enqueued to
        /// the threadpool at any given time.
        /// </summary>
        public int MaxConcurentRequest { get; private set; }

        /// <summary>
        /// The current number of pending requests, both offloaded to
        /// threadpool and stored in internal queue.
        /// </summary>
        public int RequestCount
        {
            get
            {
                return IsWebGL ? _requestCount : Thread.VolatileRead(ref _requestCount);
            }
        }

        /// <summary>
        /// This is the constructor for ThreadPoolThrottler.
        /// </summary>
        /// <param name="maxConcurrentRequests">Maximum number of requests to be enqueued to
        /// the threadpool at any given time.
        /// </param>
        public ThreadPoolThrottler(int maxConcurrentRequests)
        {
            this.MaxConcurentRequest = maxConcurrentRequests;
        }

        /// <summary>
        /// Enqueue a request to call the callback with the given state.
        /// </summary>
        /// <param name="executionContext">The state that is passed to the callback method.</param>
        /// <param name="callback">An Action delegate which needs to be invoked on the thread pool thread</param>
        /// <param name="errorCallback">An Action delegate which needs to be invoked on exception while executing the request on the thread pool thread</param>
        public void Enqueue(T executionContext, Action<T> callback, Action<Exception, T> errorCallback)
        {
            ThreadPoolOptions<T> options = new ThreadPoolOptions<T> { Callback = callback, ErrorCallback = errorCallback, State = executionContext };
            var requestNumber = IsWebGL ? ++_requestCount : Interlocked.Increment(ref _requestCount);
            if (requestNumber <= this.MaxConcurentRequest)
            {
                // If we haven't hit the limit, enqueue to threadpool.
                if (IsWebGL)
                    Callback(options);
                else
                    ThreadPool.QueueUserWorkItem(Callback, options);
            }
            else
            {
                lock (_queueLock)
                {
                    // If we hit the limit, store in the local queue
                    _queuedRequests.Enqueue(options);
                }
            }
        }

        /// <summary>
        /// Internal callback method that manages invoking 
        /// the caller's callback (_callback) and does
        /// exception handling and signaling.
        /// </summary>
        /// <param name="state"></param>
        private void Callback(object state)
        {
            ThreadPoolOptions<T> callbackState = (ThreadPoolOptions<T>)state;
            try
            {
                callbackState.Callback(callbackState.State);
            }
            catch (Exception exception)
            {
                callbackState.ErrorCallback(exception, callbackState.State);
            }
            finally
            {
                this.SignalCompletion();
            }
        }

        /// <summary>
        /// This method is used to signal that the execution 
        /// of a request is completed. This method subsequently enqueues 
        /// any pending requests if available.
        /// </summary>
        private void SignalCompletion()
        {
            ThreadPoolOptions<T> context = default(ThreadPoolOptions<T>);
            int count = 0;
            lock (_queueLock)
            {
                count = _queuedRequests.Count;
                if (count > 0)
                {
                    context = _queuedRequests.Dequeue();
                }
            }
            if (count > 0)
            {
                if (IsWebGL)
                    Callback(context);
                else
                    ThreadPool.QueueUserWorkItem(Callback, context);
            }

            if (IsWebGL)
                _requestCount--;
            else
                Interlocked.Decrement(ref _requestCount);
        }

        /// <summary>
        /// Maintains the state of an item on the request queue.
        /// </summary>
        /// <typeparam name="Q"></typeparam>
        public class ThreadPoolOptions<Q>
        {
            public Action<Q> Callback { get; set; }
            public Action<Exception, Q> ErrorCallback { get; set; }
            public Q State { get; set; }
        }

    }
}
