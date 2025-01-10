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
    /// Input for the Load operation in the object-persistence programming model
    /// </summary>
    public class LoadConfig : BaseOperationConfig
    {
        /// <summary>
        /// Property that directs <see cref="DynamoDBContext"/> to use consistent reads.
        /// If property is not set, behavior defaults to non-consistent reads.
        /// </summary>
        public bool? ConsistentRead { get; set; }

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
            config.ConsistentRead = ConsistentRead;
            config.RetrieveDateTimeInUtc = RetrieveDateTimeInUtc;

            return config;
        }
    }
}
