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
using System.Linq;
using System.Text;
using System.Threading;

namespace Amazon.S3.Util
{
    /// <summary>
    /// Represents the status of an asynchronous operation. 
    /// It adds support for Cancelation of the asynchronous operation.
    /// </summary>
    public class AsyncCancelableResult : IAsyncCancelableResult, IDisposable
    {
        private volatile bool _isCancelRequested;

        private volatile bool _isCompleted;

        private volatile bool _isCanceled;

        private ManualResetEvent _waitHandle;

        /// <summary>
        /// Gets a value that indicated whether the asynchronous operation has been canceled.
        /// </summary>
        public bool IsCanceled { get { return _isCanceled; } }

        /// <summary>
        /// Gets a user-defined object that qualifies or contains information about an
        /// asynchronous operation.
        /// </summary>
        public object AsyncState { get; private set; }

        /// <summary>
        /// Gets a System.Threading.WaitHandle that is used to wait for an asynchronous
        /// operation to complete.
        /// </summary>
        public WaitHandle AsyncWaitHandle { get { return _waitHandle; } }

        /// <summary>
        /// Gets a value that indicates whether the asynchronous operation completed
        /// synchronously.
        /// </summary>
        public bool CompletedSynchronously { get { return false; } }

        /// <summary>
        /// Gets a value that indicates whether the asynchronous operation has completed.
        /// </summary>
        public bool IsCompleted { get { return _isCompleted; } }

        /// <summary>
        /// Gets a value that indicates whether a cancel is requested.
        /// </summary>
        internal bool IsCancelRequested { get { return _isCancelRequested; } }
        
        /// <summary>
        /// The last exception that when the asynchronous operation was executed.
        /// This is used to capture the exception and re-throw it when EndOperation is called.
        /// </summary>
        internal Exception LastException { get; set; }

        /// <summary>
        /// The callback to be invoked when the asynchronous operation is completed.
        /// </summary>
        internal AsyncCallback Callback { get; set; }

        /// <summary>
        /// Constructor for AsyncCancelableResult.
        /// </summary>
        /// <param name="callback">The callback to be invoked when the asynchronous operation is completed.</param>
        /// <param name="state">Gets a user-defined object that qualifies or contains information about an
        /// asynchronous operation.
        /// </param>
        internal AsyncCancelableResult(AsyncCallback callback, object state)
        {
            this.Callback = callback;
            this.AsyncState = state;
            this._waitHandle = new ManualResetEvent(false);
        }

        /// <summary>
        /// Cancels the asynchronous operation if it's in progress.
        /// </summary>
        public void Cancel()
        {
            _isCancelRequested = true;
        }

        /// <summary>
        /// Signals that the operaton is canceled and invokes the callback.
        /// </summary>
        internal void SignalWaitHandleOnCanceled()
        {
            _isCanceled = true;
            this._waitHandle.Set();

            if (Callback!=null)
            {
                Callback(this);
            }
        }

        /// <summary>
        /// Signals that the operation is completed and invoked the callback.
        /// </summary>
        internal void SignalWaitHandleOnCompleted()
        {
            _isCompleted = true;
            this._waitHandle.Set();

            if (Callback != null)
            {
                Callback(this);
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or
        /// resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes any managed and unmanaged resources.
        /// </summary>
        /// <param name="disposing">Should pass true if called by Dispose(), pass false if
        /// called during finalization.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_waitHandle!=null)
                {
                    _waitHandle.Close();
                    _waitHandle = null;
                }
            }            
        }
    }
}
