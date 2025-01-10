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

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Input for the BatchWrite operation in the object-persistence programming model
    /// </summary>
    public class BatchWriteConfig : BaseOperationConfig
    {
        /// <summary>
        /// Property that directs <see cref="DynamoDBContext"/> to skip version checks
        /// when saving or deleting an object with a version attribute.
        /// If property is not set, version checks are performed.
        /// </summary>
        public bool? SkipVersionCheck { get; set; }

        /// <summary>
        /// Directs <see cref="DynamoDBContext" /> to ignore null values when 
        /// converting an object to a DynamoDB item. If the property is false 
        /// (or not set), null values will be interpreted as directives to 
        /// delete the specific attributes on the DynamoDB item.
        /// </summary>
        public bool? IgnoreNullValues { get; set; }

        /// <inheritdoc/>
        internal override DynamoDBOperationConfig ToDynamoDBOperationConfig()
        {
            var config = base.ToDynamoDBOperationConfig();
            config.SkipVersionCheck = SkipVersionCheck;
            config.IgnoreNullValues = IgnoreNullValues;

            return config;
        }
    }
}
