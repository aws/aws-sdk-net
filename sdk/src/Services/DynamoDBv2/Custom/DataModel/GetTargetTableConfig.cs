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
    /// Input for the GetTargetTable operation in the object-persistence programming model
    /// </summary>
#if NET8_0_OR_GREATER
    // The DataModel namespace doesn't support trimming yet, so annotate public classes/methods as incompatible
    [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(Custom.Internal.InternalConstants.RequiresUnreferencedCodeMessage)]
#endif
    public class GetTargetTableConfig : BaseOperationConfig
    {
        /// <inheritdoc/>
        internal override DynamoDBOperationConfig ToDynamoDBOperationConfig()
        {
            var config = base.ToDynamoDBOperationConfig();

            return config;
        }
    }
}
