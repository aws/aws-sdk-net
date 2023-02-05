﻿/*
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

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Represents a non-generic object for retrieving multiple items
    /// from a single DynamoDB table in a transaction.
    /// </summary>
    public partial class TransactGet
    {
        #region Public methods

        /// <summary>
        /// Executes a server call to get the items requested in a transaction.
        /// </summary>
        public void Execute()
        {
            ExecuteHelper();
        }

        #endregion
    }

    /// <summary>
    /// Class for retrieving multiple items from multiple DynamoDB tables,
    /// using multiple strongly-typed TransactGet objects.
    /// </summary>
    public partial class MultiTableTransactGet
    {
        #region Public methods

        /// <summary>
        /// Executes a multi-table transaction request against all configured transaction parts.
        /// Results are stored in the respective TransactGet objects.
        /// </summary>
        public void Execute()
        {
            ExecuteHelper();
        }

        #endregion
    }
}
