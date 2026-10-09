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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Statistics about a telemetry query execution.
    /// </summary>
    public partial class QueryStatistics
    {
        /// <summary>
        /// Gets and sets the property BytesScanned. The number of bytes scanned by the query.
        /// </summary>
        public double? BytesScanned { get; set; }

        /// <summary>
        /// Checks to see if the BytesScanned property is set.
        /// </summary>
        internal bool IsSetBytesScanned() => this.BytesScanned.HasValue;

        /// <summary>
        /// Gets and sets the property PartialResults. Information about whether the query returned
        /// partial results.
        /// </summary>
        public PartialResults PartialResults { get; set; }

        /// <summary>
        /// Checks to see if the PartialResults property is set.
        /// </summary>
        internal bool IsSetPartialResults() => this.PartialResults != null;

        /// <summary>
        /// Gets and sets the property PercentComplete. The percentage of the query that has completed.
        /// </summary>
        public int? PercentComplete { get; set; }

        /// <summary>
        /// Checks to see if the PercentComplete property is set.
        /// </summary>
        internal bool IsSetPercentComplete() => this.PercentComplete.HasValue;

        /// <summary>
        /// Gets and sets the property RecordsMatched. The number of records that matched the
        /// query criteria.
        /// </summary>
        public long? RecordsMatched { get; set; }

        /// <summary>
        /// Checks to see if the RecordsMatched property is set.
        /// </summary>
        internal bool IsSetRecordsMatched() => this.RecordsMatched.HasValue;

        /// <summary>
        /// Gets and sets the property RecordsScanned. The total number of records scanned.
        /// </summary>
        public long? RecordsScanned { get; set; }

        /// <summary>
        /// Checks to see if the RecordsScanned property is set.
        /// </summary>
        internal bool IsSetRecordsScanned() => this.RecordsScanned.HasValue;
    }
}
