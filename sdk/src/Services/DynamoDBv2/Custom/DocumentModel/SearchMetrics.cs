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
using System.Collections.Generic;
using System.Text;
using Amazon.DynamoDBv2.Model;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Provides aggregated metrics and capacity usage information for a multi-page search or query operation.
    /// </summary>
    /// <remarks>This class exposes read-only properties that summarize capacity consumption, item counts, and
    /// scan statistics across all pages retrieved during a search or query. Instances are typically returned by
    /// operations that support capacity reporting, such as paginated database queries. All properties reflect the
    /// cumulative or most recent values as appropriate, and are updated as additional pages are processed. This type is
    /// not intended to be instantiated directly.</remarks>
    public sealed class SearchMetrics
    {
        internal SearchMetrics()
        {
            _history = new List<ConsumedCapacity>();
        }

        internal List<ConsumedCapacity> _history;

        /// <summary>
        /// Gets the details of the capacity units consumed by the most recent operation.
        /// </summary>
        /// <remarks>This property is typically populated after a request to a data service that tracks
        /// consumed capacity, such as a database or storage operation. The value may be null if capacity information is
        /// not available for the last operation.</remarks>
        public ConsumedCapacity LastConsumedCapacity { get; internal set; }

        /// <summary>
        /// Gets the history of consumed capacity details for all operations performed during the search.
        /// For details, see <see href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/metrics-dimensions.html#ConsumedCapacityUnits">ConsumedCapacityUnits</see>.
        /// </summary>
        public IReadOnlyList<ConsumedCapacity> ConsumedCapacityHistory => _history;

        /// <summary>
        /// Gets the total capacity units accumulated across all operations performed during the search.
        /// For details, see <see href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/metrics-dimensions.html#ConsumedCapacityUnits">ConsumedCapacityUnits</see>.
        /// </summary>
        public double? TotalCapacityUnits { get; internal set; }

        /// <summary>
        /// Gets the total consumed read capacity units accumulated across all operations performed during the search.
        /// For details, see <see href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/metrics-dimensions.html#ConsumedReadCapacityUnits">ConsumedReadCapacityUnits</see>.
        /// </summary>
        public double? TotalReadCapacityUnits { get; internal set; }

        /// <summary>
        /// Gets the total accumulated consumed write capacity units for all operations performed during the search.
        /// For details, see <see href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/metrics-dimensions.html#ConsumedWriteCapacityUnits">ConsumedWriteCapacityUnits</see>.
        /// </summary>
        public double? TotalWriteCapacityUnits { get; internal set; }

        /// <summary>
        /// Gets the number of items scanned during the most recent operation.
        /// </summary>
        public int ScannedCountLast { get; internal set; }

        /// <summary>
        /// Gets the total number of items scanned across all operations.
        /// </summary>
        /// <remarks>This property is updated internally and reflects the cumulative count of scanned items.</remarks>
        public int ScannedCountAccumulated { get; internal set; }

        /// <summary>
        /// Number of items returned in the last operation.
        /// </summary>
        public int ItemsReturnedLast { get; internal set; }

        /// <summary>
        /// Total number of items returned across all operations.
        /// </summary>
        public int TotalItemsReturned { get; internal set; }
    }
}
