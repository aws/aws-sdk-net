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

using Amazon.Runtime;
using System.Threading;
using Amazon.Runtime.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.DynamoDBv2
{
    /// <summary>
    /// Typed DynamoDB response delegate
    /// </summary>
    /// <typeparam name="T">Typed response object</typeparam>
    /// <param name="result"><see cref="AmazonDynamoDBResult{T}"/></param>
    public delegate void AmazonDynamoDBCallback<T>(AmazonDynamoDBResult<T> result);

    /// <summary>
    /// DynamoDB response delegate
    /// </summary>
    /// <param name="result"><see cref="AmazonDynamoDBResult"/></param>
    public delegate void AmazonDynamoDBCallback(AmazonDynamoDBResult result);


    /// <summary>
    /// Typed DynamoDB result object 
    /// <seealso cref="AmazonDynamoDBResult"/>
    /// </summary>
    /// <typeparam name="T">The typed result object</typeparam>
    public class AmazonDynamoDBResult<T>
    {
        /// <summary>
        /// The result object
        /// </summary>
        public T Result { get; internal set; }

        /// <summary>
        /// Exception object in case of error
        /// </summary>
        public Exception Exception { get; internal set; }

        /// <summary>
        /// optional state object
        /// </summary>
        public object State { get; internal set; }

        /// <summary>
        /// Constructor for <see cref="AmazonDynamoDBResult{T}"/>
        /// </summary>
        /// <param name="result"></param>
        /// <param name="exception"></param>
        /// <param name="state"></param>
        public AmazonDynamoDBResult(T result, Exception exception, object state)
        {
            this.Result = result;
            this.Exception = exception;
            this.State = state;
        }
    }

    /// <summary>
    /// DynamoDB result object. 
    /// This is used when there is no response to be returned to the delegate
    /// <seealso cref="AmazonDynamoDBResult{T}"/>
    /// </summary>
    public class AmazonDynamoDBResult
    {
        /// <summary>
        /// Exception object in case of error
        /// </summary>
        public Exception Exception { get; internal set; }

        /// <summary>
        /// optional state object
        /// </summary>
        public object State { get; internal set; }

        /// <summary>
        /// Constructor for <see cref="AmazonDynamoDBResult"/>
        /// </summary>
        /// <param name="state"></param>
        public AmazonDynamoDBResult(object state)
        {
            this.State = state;
        }

        /// <summary>
        /// Constructor for <see cref="AmazonDynamoDBResult"/>
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="state"></param>
        public AmazonDynamoDBResult(Exception exception, object state)
        {
            this.Exception = exception;
            this.State = state;
        }
    }
}
