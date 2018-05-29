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
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Represents a non-generic object for writing/deleting a batch of items
    /// in a single DynamoDB table
    /// </summary>
    public abstract partial class BatchWrite
    {
        #region Public methods

        /// <summary>
        /// Initiates the asynchronous execution of the Execute operation.
        /// </summary>        
        /// <param name="callback">The callback that will be invoked when the asynchronous operation completes.</param> 
        /// <param name="asyncOptions">An instance of AsyncOptions that specifies how the async method should be executed.</param>
        public void ExecuteAsync(AmazonDynamoDBCallback callback, AsyncOptions asyncOptions = null)
        {
            asyncOptions = asyncOptions ?? new AsyncOptions();
            DynamoDBAsyncExecutor.ExecuteAsync(
                () => { ExecuteHelper(); },
                asyncOptions,
                callback);
        }

        #endregion
    }

    /// <summary>
    /// Class for writing/deleting a batch of items in multiple DynamoDB tables,
    /// using multiple strongly-typed BatchWrite objects
    /// </summary>
    public partial class MultiTableBatchWrite
    {
        #region Public methods

        /// <summary>
        /// Initiates the asynchronous execution of the Execute operation.
        /// </summary>        
        /// <param name="callback">The callback that will be invoked when the asynchronous operation completes.</param>
        /// <param name="asyncOptions">An instance of AsyncOptions that specifies how the async method should be executed.</param>
        public void ExecuteAsync(AmazonDynamoDBCallback callback, AsyncOptions asyncOptions = null)
        {
            asyncOptions = asyncOptions ?? new AsyncOptions();
            DynamoDBAsyncExecutor.ExecuteAsync(
                () => { ExecuteHelper(); },
                asyncOptions,
                callback);
        }

        #endregion
    }
}
