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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Gets metadata about a query, including the number of events that were matched, the
    /// total number of events scanned, the query run time in milliseconds, and the query's
    /// creation time.
    /// </summary>
    public partial class QueryStatisticsForDescribeQuery
    {
        /// <summary>
        /// Gets and sets the property BytesScanned. 
        /// <para>
        /// The total bytes that the query scanned in the event data store. This value matches
        /// the number of bytes for which your account is billed for the query, unless the query
        /// is still running.
        /// </para>
        /// </summary>
        public long? BytesScanned { get; set; }

        /// <summary>
        /// Checks to see if the BytesScanned property is set.
        /// </summary>
        internal bool IsSetBytesScanned() => this.BytesScanned.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the query.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EventsMatched. 
        /// <para>
        /// The number of events that matched a query.
        /// </para>
        /// </summary>
        public long? EventsMatched { get; set; }

        /// <summary>
        /// Checks to see if the EventsMatched property is set.
        /// </summary>
        internal bool IsSetEventsMatched() => this.EventsMatched.HasValue;

        /// <summary>
        /// Gets and sets the property EventsScanned. 
        /// <para>
        /// The number of events that the query scanned in the event data store.
        /// </para>
        /// </summary>
        public long? EventsScanned { get; set; }

        /// <summary>
        /// Checks to see if the EventsScanned property is set.
        /// </summary>
        internal bool IsSetEventsScanned() => this.EventsScanned.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionTimeInMillis. 
        /// <para>
        /// The query's run time, in milliseconds.
        /// </para>
        /// </summary>
        public int? ExecutionTimeInMillis { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionTimeInMillis property is set.
        /// </summary>
        internal bool IsSetExecutionTimeInMillis() => this.ExecutionTimeInMillis.HasValue;
    }
}
