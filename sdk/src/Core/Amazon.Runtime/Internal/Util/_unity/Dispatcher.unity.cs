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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Class to perform actions on a background thread.
    /// Uses a single background thread and performs actions
    /// on it in the order the data was sent through the instance.
    /// </summary>
    internal class CoroutineDispatcher<T> : IDisposable
    {
        #region Properties

        private bool isDisposed = false;
        private Action<T> action;
        private Queue<T> queue;
        private Coroutine coroutine;
        private bool shouldStop;
        public bool IsRunning { get; private set; }

        #endregion


        #region Constructor/destructor

        public CoroutineDispatcher(Action<T> action)
        {
            if (action == null)
                throw new ArgumentNullException("action");

            queue = new Queue<T>();
            shouldStop = false;
            this.action = action;

            coroutine = UnityInitializer.Instance.StartCoroutine(Run());
        }

        ~CoroutineDispatcher()
        {
            Stop();
            this.Dispose();
        }

        #endregion


        #region Dispose Pattern Implementation


        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion


        #region Public Methods

        const int MAX_QUEUE_SIZE = 100;
        public void Dispatch(T data)
        {
            if (queue.Count < MAX_QUEUE_SIZE) 
            {
                lock (queue) 
                {
                    if (queue.Count < MAX_QUEUE_SIZE)
                        queue.Enqueue(data);
                }
            }
        }

        public void Stop()
        {
            shouldStop = true;
            UnityInitializer.Instance.StopCoroutine(coroutine);
            coroutine = null;
        }

        #endregion


        #region Private methods

        private IEnumerator Run()
        {
            IsRunning = true;
            while (!shouldStop) 
            {
                HandleInvoked();
                yield return new WaitForEndOfFrame();
            }
            HandleInvoked();
            IsRunning = false;
        }

        private void HandleInvoked()
        {
            while (true) 
            {
                bool dataPresent = false;
                T data = default(T);
                lock (queue) 
                {
                    if (queue.Count > 0) 
                    {
                        data = queue.Dequeue();
                        dataPresent = true;
                    }
                }

                if (!dataPresent)
                    break;

                try 
                {
                    action(data);
                }
                catch { }
            }
        }

        #endregion
    }

    /// <summary>
    /// Class to invoke actions on a coroutine.
    /// Uses a single coroutine and invokes actions
    /// on it in the order they were invoked through the instance.
    /// </summary>
    internal class CoroutineInvoker : CoroutineDispatcher<Action>
    {
        public CoroutineInvoker()
            : base(action => action())
        {
        }
    }
}
