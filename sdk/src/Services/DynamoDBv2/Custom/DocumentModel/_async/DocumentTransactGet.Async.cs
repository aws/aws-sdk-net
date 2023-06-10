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

using System.Threading;
using System.Threading.Tasks;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Class for retrieving multiple Documents from a single DynamoDB table in a transaction.
    /// </summary>
    public partial class DocumentTransactGet
    {
        #region Public methods

        /// <summary>
        /// Executes a server call to get the documents requested in a transaction.
        /// Populates Results with the retrieved items.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecuteHelperAsync(cancellationToken);
        }

        #endregion
    }

    /// <summary>
    /// Class for retrieving multiple Documents from multiple DynamoDB tables in a transaction.
    /// </summary>
    public partial class MultiTableDocumentTransactGet
    {
        #region Public methods

        /// <summary>
        /// Executes a multi-table transaction request against all configured DocumentTransactGet objects.
        /// Results are stored in the respective DocumentTransactGet objects.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecuteHelperAsync(cancellationToken);
        }

        #endregion
    }
}
