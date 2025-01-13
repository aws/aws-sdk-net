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
using System.Diagnostics.CodeAnalysis;

using Amazon.DynamoDBv2.DocumentModel;
using ThirdParty.RuntimeBackports;

namespace Amazon.DynamoDBv2.DataModel
{
    public partial class DynamoDBContext : IDynamoDBContext
    {
        #region Table methods

        /// <inheritdoc/>
        public ITable GetTargetTable<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>()
        {
            return GetTargetTableInternal<T>(new DynamoDBFlatConfig(null, Config));
        }

        /// <inheritdoc/>
        [Obsolete("Use the GetTargetTable overload that takes GetTargetTableConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to GetTargetTable.")]
        public ITable GetTargetTable<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(DynamoDBOperationConfig operationConfig = null)
        {
            return GetTargetTableInternal<T>(new DynamoDBFlatConfig(operationConfig, Config));
        }

        /// <inheritdoc/>
        public ITable GetTargetTable<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(GetTargetTableConfig getTargetTableConfig)
        {
            return GetTargetTableInternal<T>(new DynamoDBFlatConfig(getTargetTableConfig?.ToDynamoDBOperationConfig(), Config));
        }

        #endregion
    }
}
