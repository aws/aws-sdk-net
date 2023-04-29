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

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Class for condition checking, putting, updating and/or deleting
    /// multiple items in a single DynamoDB table in a transaction.
    /// </summary>
    public partial class DocumentTransactWrite
    {
        #region Public methods

        /// <summary>
        /// Executes a server call to condition-check/put/update/delete the items specified in a transaction.
        /// </summary>
        public void Execute()
        {
            ExecuteHelper();
        }

        #endregion
    }

    /// <summary>
    /// Class for condition checking, putting, updating and/or deleting
    /// multiple items in multiple DynamoDB tables in a transaction.
    /// </summary>
    public partial class MultiTableDocumentTransactWrite
    {
        #region Public methods

        /// <summary>
        /// Executes a multi-table transactional condition-check/put/update/delete against all configured DocumentTransactWrite objects.
        /// </summary>
        public void Execute()
        {
            ExecuteHelper();
        }

        #endregion
    }
}
