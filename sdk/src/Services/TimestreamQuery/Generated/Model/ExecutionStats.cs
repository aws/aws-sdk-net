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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Statistics for a single scheduled query run.
    /// </summary>
    public partial class ExecutionStats
    {
        private long? _bytesMetered;
        private long? _cumulativeBytesScanned;
        private long? _dataWrites;
        private long? _executionTimeInMillis;
        private long? _queryResultRows;
        private long? _recordsIngested;

        /// <summary>
        /// Gets and sets the property BytesMetered. 
        /// <para>
        /// Bytes metered for a single scheduled query run.
        /// </para>
        /// </summary>
        public long? BytesMetered
        {
            get { return this._bytesMetered; }
            set { this._bytesMetered = value; }
        }

        // Check to see if BytesMetered property is set
        internal bool IsSetBytesMetered()
        {
            return this._bytesMetered.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CumulativeBytesScanned. 
        /// <para>
        /// Bytes scanned for a single scheduled query run.
        /// </para>
        /// </summary>
        public long? CumulativeBytesScanned
        {
            get { return this._cumulativeBytesScanned; }
            set { this._cumulativeBytesScanned = value; }
        }

        // Check to see if CumulativeBytesScanned property is set
        internal bool IsSetCumulativeBytesScanned()
        {
            return this._cumulativeBytesScanned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataWrites. 
        /// <para>
        /// Data writes metered for records ingested in a single scheduled query run.
        /// </para>
        /// </summary>
        public long? DataWrites
        {
            get { return this._dataWrites; }
            set { this._dataWrites = value; }
        }

        // Check to see if DataWrites property is set
        internal bool IsSetDataWrites()
        {
            return this._dataWrites.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionTimeInMillis. 
        /// <para>
        /// Total time, measured in milliseconds, that was needed for the scheduled query run
        /// to complete.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property QueryResultRows. 
        /// <para>
        /// Number of rows present in the output from running a query before ingestion to destination
        /// data source.
        /// </para>
        /// </summary>
        public long? QueryResultRows
        {
            get { return this._queryResultRows; }
            set { this._queryResultRows = value; }
        }

        // Check to see if QueryResultRows property is set
        internal bool IsSetQueryResultRows()
        {
            return this._queryResultRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordsIngested. 
        /// <para>
        /// The number of records ingested for a single scheduled query run. 
        /// </para>
        /// </summary>
        public long? RecordsIngested
        {
            get { return this._recordsIngested; }
            set { this._recordsIngested = value; }
        }

        // Check to see if RecordsIngested property is set
        internal bool IsSetRecordsIngested()
        {
            return this._recordsIngested.HasValue; 
        }

    }
}