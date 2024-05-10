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
    /// Metadata about a query, such as the number of results.
    /// </summary>
    public partial class QueryStatistics
    {
        private long? _bytesScanned;
        private int? _resultsCount;
        private int? _totalResultsCount;

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
        /// Gets and sets the property ResultsCount. 
        /// <para>
        /// The number of results returned.
        /// </para>
        /// </summary>
        public int? ResultsCount
        {
            get { return this._resultsCount; }
            set { this._resultsCount = value; }
        }

        // Check to see if ResultsCount property is set
        internal bool IsSetResultsCount()
        {
            return this._resultsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalResultsCount. 
        /// <para>
        /// The total number of results returned by a query.
        /// </para>
        /// </summary>
        public int? TotalResultsCount
        {
            get { return this._totalResultsCount; }
            set { this._totalResultsCount = value; }
        }

        // Check to see if TotalResultsCount property is set
        internal bool IsSetTotalResultsCount()
        {
            return this._totalResultsCount.HasValue; 
        }

    }
}