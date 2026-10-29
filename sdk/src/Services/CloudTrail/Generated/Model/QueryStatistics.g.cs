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
    /// Metadata about a query, such as the number of results.
    /// </summary>
    public partial class QueryStatistics
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
        /// Gets and sets the property ResultsCount. 
        /// <para>
        /// The number of results returned.
        /// </para>
        /// </summary>
        public int? ResultsCount { get; set; }

        /// <summary>
        /// Checks to see if the ResultsCount property is set.
        /// </summary>
        internal bool IsSetResultsCount() => this.ResultsCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalResultsCount. 
        /// <para>
        /// The total number of results returned by a query.
        /// </para>
        /// </summary>
        public int? TotalResultsCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalResultsCount property is set.
        /// </summary>
        internal bool IsSetTotalResultsCount() => this.TotalResultsCount.HasValue;
    }
}
