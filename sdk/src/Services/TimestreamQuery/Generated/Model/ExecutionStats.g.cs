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

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Statistics for a single scheduled query run.
    /// </summary>
    public partial class ExecutionStats
    {
        /// <summary>
        /// Gets and sets the property BytesMetered. 
        /// <para>
        /// Bytes metered for a single scheduled query run.
        /// </para>
        /// </summary>
        public long? BytesMetered { get; set; }

        /// <summary>
        /// Checks to see if the BytesMetered property is set.
        /// </summary>
        internal bool IsSetBytesMetered() => this.BytesMetered.HasValue;

        /// <summary>
        /// Gets and sets the property CumulativeBytesScanned. 
        /// <para>
        /// Bytes scanned for a single scheduled query run.
        /// </para>
        /// </summary>
        public long? CumulativeBytesScanned { get; set; }

        /// <summary>
        /// Checks to see if the CumulativeBytesScanned property is set.
        /// </summary>
        internal bool IsSetCumulativeBytesScanned() => this.CumulativeBytesScanned.HasValue;

        /// <summary>
        /// Gets and sets the property DataWrites. 
        /// <para>
        /// Data writes metered for records ingested in a single scheduled query run.
        /// </para>
        /// </summary>
        public long? DataWrites { get; set; }

        /// <summary>
        /// Checks to see if the DataWrites property is set.
        /// </summary>
        internal bool IsSetDataWrites() => this.DataWrites.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionTimeInMillis. 
        /// <para>
        /// Total time, measured in milliseconds, that was needed for the scheduled query run
        /// to complete.
        /// </para>
        /// </summary>
        public long? ExecutionTimeInMillis { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionTimeInMillis property is set.
        /// </summary>
        internal bool IsSetExecutionTimeInMillis() => this.ExecutionTimeInMillis.HasValue;

        /// <summary>
        /// Gets and sets the property QueryResultRows. 
        /// <para>
        /// Number of rows present in the output from running a query before ingestion to destination
        /// data source.
        /// </para>
        /// </summary>
        public long? QueryResultRows { get; set; }

        /// <summary>
        /// Checks to see if the QueryResultRows property is set.
        /// </summary>
        internal bool IsSetQueryResultRows() => this.QueryResultRows.HasValue;

        /// <summary>
        /// Gets and sets the property RecordsIngested. 
        /// <para>
        /// The number of records ingested for a single scheduled query run. 
        /// </para>
        /// </summary>
        public long? RecordsIngested { get; set; }

        /// <summary>
        /// Checks to see if the RecordsIngested property is set.
        /// </summary>
        internal bool IsSetRecordsIngested() => this.RecordsIngested.HasValue;
    }
}
