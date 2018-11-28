/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Contains the number of log events scanned by the query, the number of log events that
    /// matched the query criteria, and the total number of bytes in the log events that were
    /// scanned.
    /// </summary>
    public partial class QueryStatistics
    {
        private double? _bytesScanned;
        private double? _recordsMatched;
        private double? _recordsScanned;

        /// <summary>
        /// Gets and sets the property BytesScanned. 
        /// <para>
        /// The total number of bytes in the log events scanned during the query.
        /// </para>
        /// </summary>
        public double BytesScanned
        {
            get { return this._bytesScanned.GetValueOrDefault(); }
            set { this._bytesScanned = value; }
        }

        // Check to see if BytesScanned property is set
        internal bool IsSetBytesScanned()
        {
            return this._bytesScanned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordsMatched. 
        /// <para>
        /// The number of log events that matched the query string.
        /// </para>
        /// </summary>
        public double RecordsMatched
        {
            get { return this._recordsMatched.GetValueOrDefault(); }
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
        /// The total number of log events scanned during the query.
        /// </para>
        /// </summary>
        public double RecordsScanned
        {
            get { return this._recordsScanned.GetValueOrDefault(); }
            set { this._recordsScanned = value; }
        }

        // Check to see if RecordsScanned property is set
        internal bool IsSetRecordsScanned()
        {
            return this._recordsScanned.HasValue; 
        }

    }
}