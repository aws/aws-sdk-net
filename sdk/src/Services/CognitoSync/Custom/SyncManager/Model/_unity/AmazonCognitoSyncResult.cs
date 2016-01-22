//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

using System;
using Amazon.Runtime;

namespace Amazon.CognitoSync.SyncManager
{
    /// <summary>
    /// Callback for asynchronous Sync Manager operations
    /// </summary>
    /// <typeparam name="TResponse">A response object type</typeparam>
    /// <param name="result">Result</param>
    public delegate void AmazonCognitoSyncCallback<TResponse>(AmazonCognitoSyncResult<TResponse> result);

    /// <summary>
    /// Callback for asynchronous Sync Manager operations
    /// </summary>
    /// <param name="result">Result</param>
    public delegate void AmazonCognitoSyncCallback(AmazonCognitoSyncResult result);

    /// <summary>
    /// A result object passed back in the callback.
    /// </summary>
    /// <typeparam name="TResponse">A response object type</typeparam>
    public class AmazonCognitoSyncResult<TResponse>
    {
        /// <summary>
        /// A response object.
        /// </summary>
        public TResponse Response { get; internal set; }

        /// <summary>
        /// The exception that occured
        /// </summary>
        public Exception Exception { get; internal set; }

        /// <summary>
        /// A user defined state passed back from callback
        /// </summary>
        public object State { get; internal set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="state">A user defined state passed back from callback</param>
        public AmazonCognitoSyncResult(object state)
        {
            this.State = state;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="response">A response object</param>
        /// <param name="exception">The exception that occured</param>
        /// <param name="state">A user defined state passed back from callback</param>
        public AmazonCognitoSyncResult(TResponse response, Exception exception, object state)
        {
            this.Response = response;
            this.Exception = exception;
            this.State = state;
        }
    }

    /// <summary>
    /// A result object passed back in the callback.
    /// </summary>
    public class AmazonCognitoSyncResult
    {
        /// <summary>
        /// The exception that occured
        /// </summary>
        public Exception Exception { get; internal set; }

        /// <summary>
        /// A user defined state passed back from callback
        /// </summary>
        public object State { get; internal set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="state">A user defined state passed back from callback</param>
        public AmazonCognitoSyncResult(object state)
        {
            this.State = state;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="exception">The exception that occured</param>
        /// <param name="state">A user defined state passed back from callback</param>
        public AmazonCognitoSyncResult(Exception exception, object state)
        {
            this.Exception = exception;
            this.State = state;
        }
    }

}
