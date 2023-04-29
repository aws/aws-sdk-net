/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Represents a non-generic object for writing/deleting/version-checking multiple items
    /// in a single DynamoDB table in a transaction.
    /// </summary>
    public abstract partial class TransactWrite
    {
        #region Public methods

        /// <summary>
        /// Executes a server call to write/delete/version-check the items requested in a transaction.
        /// </summary>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">
        /// A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        /// procedure using the AsyncState property.
        /// </param>
        /// <returns>
        /// An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecute
        /// operation.
        /// </returns>
        public IAsyncResult BeginExecute(AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { ExecuteHelper(); return null; }, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the Execute operation.
        /// <seealso cref="Amazon.DynamoDBv2.DataModel.TransactWrite.Execute"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecute.</param>
        public void EndExecute(IAsyncResult asyncResult)
        {
            DynamoDBAsyncExecutor.EndOperation(asyncResult);
        }

        #endregion
    }

    /// <summary>
    /// Class for writing/deleting/version-checking multiple items in multiple DynamoDB tables,
    /// using multiple strongly-typed TransactWrite objects.
    /// </summary>
    public partial class MultiTableTransactWrite
    {
        #region Public methods

        /// <summary>
        /// Executes a multi-table transaction request against all configured TransactWrite objects.
        /// </summary>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">
        /// A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        /// procedure using the AsyncState property.
        /// </param>
        /// <returns>
        /// An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecute
        /// operation.
        /// </returns>
        public IAsyncResult BeginExecute(AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { ExecuteHelper(); return null; }, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the Execute operation.
        /// <seealso cref="Amazon.DynamoDBv2.DataModel.MultiTableTransactWrite.Execute"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecute.</param>
        public void EndExecute(IAsyncResult asyncResult)
        {
            DynamoDBAsyncExecutor.EndOperation(asyncResult);
        }

        #endregion
    }
}
