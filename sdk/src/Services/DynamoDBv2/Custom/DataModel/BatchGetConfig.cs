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
    /// Input for the BatchGet operation in the object-persistence programming model
    /// </summary>
    public class BatchGetConfig : BaseOperationConfig
    {
        /// <summary>
        /// Property that directs <see cref="DynamoDBContext"/> to use consistent reads.
        /// If property is not set, behavior defaults to non-consistent reads.
        /// </summary>
        /// <remarks>
        /// Refer to the <see href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
        /// Read Consistency</see> topic in the DynamoDB Developer Guide for more information.
        /// </remarks>
        public bool? ConsistentRead { get; set; }

        /// <summary>
        /// If true, all <see cref="DateTime"/> properties are retrieved in UTC timezone while reading data from DynamoDB. Else, the local timezone is used.
        /// </summary>
        /// <remarks>
        /// This setting is only applicable to the high-level library. Service calls made via 
        /// <see cref="AmazonDynamoDBClient"/> will always return <see cref="DateTime"/> attributes in UTC.
        /// </remarks>
        public bool? RetrieveDateTimeInUtc { get; set; }

        /// <summary>
        /// The maximum number of <c>BatchGetItem</c> service calls the SDK is allowed to have in flight
        /// at the same time when a request contains more keys than fit in a single call.
        /// </summary>
        /// <remarks>
        /// DynamoDB limits a single <c>BatchGetItem</c> call to 100 keys (and 16 MB). When you request more
        /// keys than that, the SDK automatically splits the work into multiple calls. By default those calls
        /// are made one after another. Set this property to a value greater than 1 to let the SDK send several
        /// of them at once, which can noticeably reduce the total time to retrieve a large number of items.
        /// <para>
        /// Leaving this property unset (or setting it to 1) preserves the default behavior of sending the calls
        /// sequentially. Values less than 1 are treated as 1.
        /// </para>
        /// <para>
        /// Choose this value with your table's read throughput in mind. A higher degree of parallelism drives
        /// reads at the table harder and in a shorter window, which makes request throttling more likely on
        /// tables that are not provisioned (or scaled) for the resulting rate. Start with a small value and
        /// increase it only if your table has the capacity to absorb the additional concurrent reads.
        /// </para>
        /// <para>
        /// This property only applies to the asynchronous execution path (<c>ExecuteAsync</c>). It has no effect
        /// on the synchronous <c>Execute</c> method, which always sends the calls sequentially.
        /// </para>
        /// </remarks>
        public int? MaxParallelBatches { get; set; }

        /// <inheritdoc/>
        internal override DynamoDBOperationConfig ToDynamoDBOperationConfig()
        {
            var config = base.ToDynamoDBOperationConfig();
            config.ConsistentRead = ConsistentRead;
            config.RetrieveDateTimeInUtc = RetrieveDateTimeInUtc;
            config.MaxParallelBatches = MaxParallelBatches;

            return config;
        }
    }
}
