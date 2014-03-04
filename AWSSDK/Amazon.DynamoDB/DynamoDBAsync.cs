/*
 * Copyright 2012-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.DynamoDB.Model;
using Amazon.Runtime;
using Amazon.Util;
using System.Threading;

namespace Amazon.DynamoDB
{
    internal delegate object AsyncCall();

    internal class DynamoDBAsyncResult : IAsyncResult
    {
        private ManualResetEvent _waitHandle;

        public DynamoDBAsyncResult(AsyncCallback callback, object state)
        {
            this.Callback = callback;
            this.AsyncState = state;
            this._waitHandle = new ManualResetEvent(false);
        }
        public DynamoDBAsyncResult()
        {
        }

        #region IAsyncResult methods

        public bool CompletedSynchronously
        {
            get { return false; }
        }

        public bool IsCompleted { get; private set; }

        public object AsyncState { get; private set; }

        public WaitHandle AsyncWaitHandle
        {
            get { return this._waitHandle; }
        }

        #endregion

        public void SignalWaitHandle()
        {
            this.IsCompleted = true;
            this._waitHandle.Set();
        }

        public AsyncCallback Callback { get; private set; }

        public Exception LastException { get; set; }

        public object Return { get; set; }
    }

    internal static class DynamoDBAsyncExecutor
    {
        public static void Execute(AsyncCall call, DynamoDBAsyncResult result)
        {
            try
            {
                result.Return = call();
            }
            catch (Exception e)
            {
                result.LastException = e;
                result.Return = null;
            }
            finally
            {
                result.SignalWaitHandle();
                if (result.Callback != null)
                {
                    result.Callback(result);
                }
            }
        }

        public static IAsyncResult BeginOperation(AsyncCall call, AsyncCallback callback, object state)
        {
            DynamoDBAsyncResult result = new DynamoDBAsyncResult(callback, state);
            ThreadPool.QueueUserWorkItem(s => Execute(call, result));
            return result;
        }

        public static object EndOperation(IAsyncResult result)
        {
            DynamoDBAsyncResult asyncResult = result as DynamoDBAsyncResult;
            if (asyncResult == null)
                return null;

            if (!asyncResult.CompletedSynchronously)
            {
                WaitHandle.WaitAll(new WaitHandle[] { asyncResult.AsyncWaitHandle });
            }

            if (asyncResult.LastException != null)
            {
                AWSSDKUtils.PreserveStackTrace(asyncResult.LastException);
                throw asyncResult.LastException;
            }

            return asyncResult.Return;
        }
    }
}
