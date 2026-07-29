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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains statistics about a completed query execution.
    /// </summary>
    public partial class QueryStatistics
    {
        private long? _bytesScanned;
        private long? _executionTimeInMillis;
        private long? _rowCount;

        /// <summary>
        /// Gets and sets the property BytesScanned. 
        /// <para>
        /// The total number of bytes scanned during query execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ExecutionTimeInMillis. 
        /// <para>
        /// The total query execution time, in milliseconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? ExecutionTimeInMillis
        {
            get { return this._executionTimeInMillis; }
            set { this._executionTimeInMillis = value; }
        }

        // Check to see if ExecutionTimeInMillis property is set
        internal bool IsSetExecutionTimeInMillis()
        {
            return this._executionTimeInMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RowCount. 
        /// <para>
        /// The total number of rows returned by the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? RowCount
        {
            get { return this._rowCount; }
            set { this._rowCount = value; }
        }

        // Check to see if RowCount property is set
        internal bool IsSetRowCount()
        {
            return this._rowCount.HasValue; 
        }

    }
}