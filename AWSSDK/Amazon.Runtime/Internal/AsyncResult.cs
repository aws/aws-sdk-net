﻿/*
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
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Runtime.Internal
{
    public class AsyncResult : IAsyncResult
    {
        // Private members

        private ManualResetEvent _waitHandle = new ManualResetEvent(false);
        private object _lockObj;
        private Stopwatch _stopWatch;


        // Constructor
        internal AsyncResult(IRequest request, AsyncCallback callback, object state, bool completeSynchronized, AbstractAWSSigner signer, ResponseUnmarshaller unmarshaller)
        {
            this.Request = request;
            this.Callback = callback;
            this.State = state;
            this.CompletedSynchronously = completeSynchronized;
            this.Signer = signer;
            this.Unmarshaller = unmarshaller;
            this.RequestName = request.OriginalRequest.GetType().Name;
            this.Metrics = new RequestMetrics();

            this._lockObj = new object();

            this._stopWatch = Stopwatch.StartNew();
            this._stopWatch.Start();
        }


        // Properties

        internal Exception Exception { get; set; }

        internal int RetriesAttempt { get; set; }

        internal AsyncRequestState RequestState { get; set; }

        internal object FinalResponse { get; set; }

        internal byte[] RequestData { get; set; }

        internal Stream RequestStream { get; set; }


        // Read-only properties

        internal ResponseUnmarshaller Unmarshaller { get; private set; }

        internal IRequest Request { get; private set; }

        internal AsyncCallback Callback { get; private set; }

        internal AbstractAWSSigner Signer { get; private set; }

        internal object State { get; private set; }

        internal string RequestName { get; private set; }

        internal RequestMetrics Metrics { get; private set; }

        public bool CompletedSynchronously { get; private set; }

        public bool IsCompleted { get; private set; }

        public object AsyncState
        {
            get { return this.State; }
        }

        public WaitHandle AsyncWaitHandle
        {
            get
            {
                if (this._waitHandle != null)
                {
                    return this._waitHandle;
                }

                lock (this._lockObj)
                {
                    if (this._waitHandle == null)
                    {
                        this._waitHandle = new ManualResetEvent(this.IsCompleted);
                    }
                }

                return this._waitHandle;
            }
        }


        // Methods
        internal void SetCompletedSynchronously(bool completedSynchronously)
        {
            this.CompletedSynchronously = completedSynchronously;
        }

        internal void SignalWaitHandle()
        {
            this.IsCompleted = true;
            if (this._waitHandle != null)
            {
                this._waitHandle.Set();
            }
        }

        #region Metric properties

        private Guid id = Guid.NewGuid();
        internal Guid Id { get { return this.id; } }

        #endregion

        public class AsyncRequestState
        {
            public AsyncRequestState(HttpWebRequest webRequest, byte[] requestData, Stream requestStream)
            {
                this.WebRequest = webRequest;
                this.RequestData = requestData;
                this.RequestStream = requestStream;
            }

            internal HttpWebRequest WebRequest { get; private set; }

            internal byte[] RequestData { get; private set; }
            internal Stream RequestStream { get; private set; }


            internal bool GetRequestStreamCallbackCalled { get; set; }

            internal bool GetResponseCallbackCalled { get; set; }
        }
    }
}
