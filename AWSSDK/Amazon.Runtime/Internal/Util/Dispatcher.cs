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
using System.Threading;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Class to invoke actions on a background thread.
    /// Uses a single background thread and invokes actions
    /// on it in the order they were invoked through the instance.
    /// </summary>
    internal class BackgroundDispatcher
    {
        #region Properties

        private Queue<Action> queue;
        private Thread backgroundThread;
        private AutoResetEvent resetEvent;
        private bool shouldStop;
        public bool IsRunning { get; private set; }

        #endregion


        #region Constructor/destructor

        public BackgroundDispatcher()
        {
            queue = new Queue<Action>();
            resetEvent = new AutoResetEvent(false);
            shouldStop = false;

            backgroundThread = new Thread(Run);
            backgroundThread.IsBackground = true;
            backgroundThread.Start();
        }

        ~BackgroundDispatcher()
        {
            Stop();
        }

        #endregion


        #region Public Methods

        public void Invoke(Action action)
        {
            if (!IsRunning)
                throw new InvalidOperationException("Dispatcher not running");

            lock (queue)
            {
                queue.Enqueue(action);
            }
            resetEvent.Set();
        }

        public void Stop()
        {
            shouldStop = true;
            resetEvent.Set();
        }

        #endregion


        #region Private methods

        private void Run()
        {
            IsRunning = true;
            while (!shouldStop)
            {
                RunInvoked();
                resetEvent.WaitOne();
            }
            RunInvoked();
            IsRunning = false;
        }

        private void RunInvoked()
        {
            while (true)
            {
                Action action = null;
                lock (queue)
                {
                    if (queue.Count > 0)
                    {
                        action = queue.Dequeue();
                    }
                }
                if (action == null)
                    break;

                try
                {
                    action();
                }
                catch { }
            }
        }

        #endregion
    }
}
