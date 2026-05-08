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
    /// Input for the TransactGet operation in the object-persistence programming model
    /// </summary>
    public class TransactGetConfig : BaseOperationConfig
    {
        /// <summary>
        /// If true, only attributes that are mapped to properties on the .NET type will be retrieved,
        /// using a projection expression. If false, all attributes of the item are retrieved.
        /// </summary>
        /// <remarks>
        /// Defaults to true, matching the auto-projection behavior of Query and Scan operations.
        /// Individual items can override this via <see cref="TransactGetItemConfig.ProjectionExpression"/>.
        /// </remarks>
        public bool ProjectMappedAttributesOnly { get; set; } = true;

        /// <summary>
        /// If true, all <see cref="DateTime"/> properties are retrieved in UTC timezone while reading data from DynamoDB. Else, the local timezone is used.
        /// </summary>
        /// <remarks>
        /// This setting is only applicable to the high-level library. Service calls made via
        /// <see cref="AmazonDynamoDBClient"/> will always return <see cref="DateTime"/> attributes in UTC.
        /// </remarks>
        public bool? RetrieveDateTimeInUtc { get; set; }

        /// <inheritdoc/>
        internal override DynamoDBOperationConfig ToDynamoDBOperationConfig()
        {
            var config = base.ToDynamoDBOperationConfig();
            config.RetrieveDateTimeInUtc = RetrieveDateTimeInUtc;

            return config;
        }
    }
}
