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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Statistics about a telemetry query execution.
    /// </summary>
    public partial class QueryStatistics
    {
        private double? _bytesScanned;
        private PartialResults _partialResults;
        private int? _percentComplete;
        private long? _recordsMatched;
        private long? _recordsScanned;

        /// <summary>
        /// Gets and sets the property BytesScanned. 
        /// <para>
        /// The number of bytes scanned by the query.
        /// </para>
        /// </summary>
        public double? BytesScanned
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
        /// Gets and sets the property PartialResults. 
        /// <para>
        /// Information about whether the query returned partial results.
        /// </para>
        /// </summary>
        public PartialResults PartialResults
        {
            get { return this._partialResults; }
            set { this._partialResults = value; }
        }

        // Check to see if PartialResults property is set
        internal bool IsSetPartialResults()
        {
            return this._partialResults != null;
        }

        /// <summary>
        /// Gets and sets the property PercentComplete. 
        /// <para>
        /// The percentage of the query that has completed.
        /// </para>
        /// </summary>
        public int? PercentComplete
        {
            get { return this._percentComplete; }
            set { this._percentComplete = value; }
        }

        // Check to see if PercentComplete property is set
        internal bool IsSetPercentComplete()
        {
            return this._percentComplete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordsMatched. 
        /// <para>
        /// The number of records that matched the query criteria.
        /// </para>
        /// </summary>
        public long? RecordsMatched
        {
            get { return this._recordsMatched; }
            set { this._recordsMatched = value; }
        }

        // Check to see if RecordsMatched property is set
        internal bool IsSetRecordsMatched()
        {
            return this._recordsMatched.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordsScanned. 
        /// <para>
        /// The total number of records scanned.
        /// </para>
        /// </summary>
        public long? RecordsScanned
        {
            get { return this._recordsScanned; }
            set { this._recordsScanned = value; }
        }

        // Check to see if RecordsScanned property is set
        internal bool IsSetRecordsScanned()
        {
            return this._recordsScanned.HasValue; 
        }

    }
}