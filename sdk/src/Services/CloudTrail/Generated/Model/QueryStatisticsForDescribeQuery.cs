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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
        private long? _bytesScanned;
        private DateTime? _creationTime;
        private long? _eventsMatched;
        private long? _eventsScanned;
        private int? _executionTimeInMillis;

        /// <summary>
        /// Gets and sets the property BytesScanned. 
        /// <para>
        /// The total bytes that the query scanned in the event data store. This value matches
        /// the number of bytes for which your account is billed for the query, unless the query
        /// is still running.
        /// </para>
        /// </summary>
        public long? BytesScanned
        {
            get { return this._bytesScanned; }
            set { this._bytesScanned = value; }
        }

        // Check to see if BytesScanned property is set
        internal bool IsSetBytesScanned()
        {
            return this._bytesScanned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the query.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventsMatched. 
        /// <para>
        /// The number of events that matched a query.
        /// </para>
        /// </summary>
        public long? EventsMatched
        {
            get { return this._eventsMatched; }
            set { this._eventsMatched = value; }
        }

        // Check to see if EventsMatched property is set
        internal bool IsSetEventsMatched()
        {
            return this._eventsMatched.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventsScanned. 
        /// <para>
        /// The number of events that the query scanned in the event data store.
        /// </para>
        /// </summary>
        public long? EventsScanned
        {
            get { return this._eventsScanned; }
            set { this._eventsScanned = value; }
        }

        // Check to see if EventsScanned property is set
        internal bool IsSetEventsScanned()
        {
            return this._eventsScanned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionTimeInMillis. 
        /// <para>
        /// The query's run time, in milliseconds.
        /// </para>
        /// </summary>
        public int? ExecutionTimeInMillis
        {
            get { return this._executionTimeInMillis; }
            set { this._executionTimeInMillis = value; }
        }

        // Check to see if ExecutionTimeInMillis property is set
        internal bool IsSetExecutionTimeInMillis()
        {
            return this._executionTimeInMillis.HasValue; 
        }

    }
}