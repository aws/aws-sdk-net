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
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Amazon.S3.Transfer.Internal
{
    internal class TransferAsyncResult : IAsyncResult
    {
        AsyncCallback _callback;
        object _state;
        bool _isComplete;
        ManualResetEvent _waitHandle;
        Exception _lastException;
        object _return;

        internal TransferAsyncResult(AsyncCallback callback, object state)
        {
            this._callback = callback;
            this._state = state;
            this._waitHandle = new ManualResetEvent(false);
        }

        public bool CompletedSynchronously
        {
            get { return false; }
        }

        public bool IsCompleted
        {
            get { return this._isComplete; }
        }

        public object AsyncState
        {
            get { return this._state; }
        }

        public WaitHandle AsyncWaitHandle
        {
            get { return this._waitHandle; }
        }

        internal void SignalWaitHandle()
        {
            this._isComplete = true;
            this._waitHandle.Set();
        }

        internal AsyncCallback Callback
        {
            get { return this._callback; }
        }

        internal Exception LastException
        {
            get { return this._lastException; }
            set { this._lastException = value; }
        }

        internal object Return
        {
            get { return this._return; }
            set { this._return = value; }
        }
    }
}
