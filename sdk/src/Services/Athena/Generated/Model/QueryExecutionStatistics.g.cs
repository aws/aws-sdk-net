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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// The amount of data scanned during the query execution and the amount of time that
    /// it took to execute, and the type of statement that was run.
    /// </summary>
    public partial class QueryExecutionStatistics
    {
        /// <summary>
        /// Gets and sets the property DataManifestLocation. 
        /// <para>
        /// The location and file name of a data manifest file. The manifest file is saved to
        /// the Athena query results location in Amazon S3. The manifest file tracks files that
        /// the query wrote to Amazon S3. If the query fails, the manifest file also tracks files
        /// that the query intended to write. The manifest is useful for identifying orphaned
        /// files resulting from a failed query. For more information, see <a href="https://docs.aws.amazon.com/athena/latest/ug/querying.html">Working
        /// with Query Results, Output Files, and Query History</a> in the <i>Amazon Athena User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string DataManifestLocation { get; set; }

        /// <summary>
        /// Checks to see if the DataManifestLocation property is set.
        /// </summary>
        internal bool IsSetDataManifestLocation() => this.DataManifestLocation != null;

        /// <summary>
        /// Gets and sets the property DataScannedInBytes. 
        /// <para>
        /// The number of bytes in the data that was queried.
        /// </para>
        /// </summary>
        public long? DataScannedInBytes { get; set; }

        /// <summary>
        /// Checks to see if the DataScannedInBytes property is set.
        /// </summary>
        internal bool IsSetDataScannedInBytes() => this.DataScannedInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property DpuCount. 
        /// <para>
        /// The number of Data Processing Units (DPUs) that Athena used to run the query.
        /// </para>
        /// </summary>
        public double? DpuCount { get; set; }

        /// <summary>
        /// Checks to see if the DpuCount property is set.
        /// </summary>
        internal bool IsSetDpuCount() => this.DpuCount.HasValue;

        /// <summary>
        /// Gets and sets the property EngineExecutionTimeInMillis. 
        /// <para>
        /// The number of milliseconds that the query took to execute.
        /// </para>
        /// </summary>
        public long? EngineExecutionTimeInMillis { get; set; }

        /// <summary>
        /// Checks to see if the EngineExecutionTimeInMillis property is set.
        /// </summary>
        internal bool IsSetEngineExecutionTimeInMillis() => this.EngineExecutionTimeInMillis.HasValue;

        /// <summary>
        /// Gets and sets the property QueryPlanningTimeInMillis. 
        /// <para>
        /// The number of milliseconds that Athena took to plan the query processing flow. This
        /// includes the time spent retrieving table partitions from the data source. Note that
        /// because the query engine performs the query planning, query planning time is a subset
        /// of engine processing time.
        /// </para>
        /// </summary>
        public long? QueryPlanningTimeInMillis { get; set; }

        /// <summary>
        /// Checks to see if the QueryPlanningTimeInMillis property is set.
        /// </summary>
        internal bool IsSetQueryPlanningTimeInMillis() => this.QueryPlanningTimeInMillis.HasValue;

        /// <summary>
        /// Gets and sets the property QueryQueueTimeInMillis. 
        /// <para>
        /// The number of milliseconds that the query was in your query queue waiting for resources.
        /// Note that if transient errors occur, Athena might automatically add the query back
        /// to the queue.
        /// </para>
        /// </summary>
        public long? QueryQueueTimeInMillis { get; set; }

        /// <summary>
        /// Checks to see if the QueryQueueTimeInMillis property is set.
        /// </summary>
        internal bool IsSetQueryQueueTimeInMillis() => this.QueryQueueTimeInMillis.HasValue;

        /// <summary>
        /// Gets and sets the property ResultReuseInformation. 
        /// <para>
        /// Contains information about whether previous query results were reused for the query.
        /// </para>
        /// </summary>
        public ResultReuseInformation ResultReuseInformation { get; set; }

        /// <summary>
        /// Checks to see if the ResultReuseInformation property is set.
        /// </summary>
        internal bool IsSetResultReuseInformation() => this.ResultReuseInformation != null;

        /// <summary>
        /// Gets and sets the property ServicePreProcessingTimeInMillis. 
        /// <para>
        /// The number of milliseconds that Athena took to preprocess the query before submitting
        /// the query to the query engine.
        /// </para>
        /// </summary>
        public long? ServicePreProcessingTimeInMillis { get; set; }

        /// <summary>
        /// Checks to see if the ServicePreProcessingTimeInMillis property is set.
        /// </summary>
        internal bool IsSetServicePreProcessingTimeInMillis() => this.ServicePreProcessingTimeInMillis.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceProcessingTimeInMillis. 
        /// <para>
        /// The number of milliseconds that Athena took to finalize and publish the query results
        /// after the query engine finished running the query.
        /// </para>
        /// </summary>
        public long? ServiceProcessingTimeInMillis { get; set; }

        /// <summary>
        /// Checks to see if the ServiceProcessingTimeInMillis property is set.
        /// </summary>
        internal bool IsSetServiceProcessingTimeInMillis() => this.ServiceProcessingTimeInMillis.HasValue;

        /// <summary>
        /// Gets and sets the property TotalExecutionTimeInMillis. 
        /// <para>
        /// The number of milliseconds that Athena took to run the query.
        /// </para>
        /// </summary>
        public long? TotalExecutionTimeInMillis { get; set; }

        /// <summary>
        /// Checks to see if the TotalExecutionTimeInMillis property is set.
        /// </summary>
        internal bool IsSetTotalExecutionTimeInMillis() => this.TotalExecutionTimeInMillis.HasValue;
    }
}
