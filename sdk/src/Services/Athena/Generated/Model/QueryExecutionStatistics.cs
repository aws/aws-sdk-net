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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
        private string _dataManifestLocation;
        private long? _dataScannedInBytes;
        private long? _engineExecutionTimeInMillis;
        private long? _queryPlanningTimeInMillis;
        private long? _queryQueueTimeInMillis;
        private ResultReuseInformation _resultReuseInformation;
        private long? _servicePreProcessingTimeInMillis;
        private long? _serviceProcessingTimeInMillis;
        private long? _totalExecutionTimeInMillis;

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
        public string DataManifestLocation
        {
            get { return this._dataManifestLocation; }
            set { this._dataManifestLocation = value; }
        }

        // Check to see if DataManifestLocation property is set
        internal bool IsSetDataManifestLocation()
        {
            return this._dataManifestLocation != null;
        }

        /// <summary>
        /// Gets and sets the property DataScannedInBytes. 
        /// <para>
        /// The number of bytes in the data that was queried.
        /// </para>
        /// </summary>
        public long? DataScannedInBytes
        {
            get { return this._dataScannedInBytes; }
            set { this._dataScannedInBytes = value; }
        }

        // Check to see if DataScannedInBytes property is set
        internal bool IsSetDataScannedInBytes()
        {
            return this._dataScannedInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngineExecutionTimeInMillis. 
        /// <para>
        /// The number of milliseconds that the query took to execute.
        /// </para>
        /// </summary>
        public long? EngineExecutionTimeInMillis
        {
            get { return this._engineExecutionTimeInMillis; }
            set { this._engineExecutionTimeInMillis = value; }
        }

        // Check to see if EngineExecutionTimeInMillis property is set
        internal bool IsSetEngineExecutionTimeInMillis()
        {
            return this._engineExecutionTimeInMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryPlanningTimeInMillis. 
        /// <para>
        /// The number of milliseconds that Athena took to plan the query processing flow. This
        /// includes the time spent retrieving table partitions from the data source. Note that
        /// because the query engine performs the query planning, query planning time is a subset
        /// of engine processing time.
        /// </para>
        /// </summary>
        public long? QueryPlanningTimeInMillis
        {
            get { return this._queryPlanningTimeInMillis; }
            set { this._queryPlanningTimeInMillis = value; }
        }

        // Check to see if QueryPlanningTimeInMillis property is set
        internal bool IsSetQueryPlanningTimeInMillis()
        {
            return this._queryPlanningTimeInMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryQueueTimeInMillis. 
        /// <para>
        /// The number of milliseconds that the query was in your query queue waiting for resources.
        /// Note that if transient errors occur, Athena might automatically add the query back
        /// to the queue.
        /// </para>
        /// </summary>
        public long? QueryQueueTimeInMillis
        {
            get { return this._queryQueueTimeInMillis; }
            set { this._queryQueueTimeInMillis = value; }
        }

        // Check to see if QueryQueueTimeInMillis property is set
        internal bool IsSetQueryQueueTimeInMillis()
        {
            return this._queryQueueTimeInMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResultReuseInformation. 
        /// <para>
        /// Contains information about whether previous query results were reused for the query.
        /// </para>
        /// </summary>
        public ResultReuseInformation ResultReuseInformation
        {
            get { return this._resultReuseInformation; }
            set { this._resultReuseInformation = value; }
        }

        // Check to see if ResultReuseInformation property is set
        internal bool IsSetResultReuseInformation()
        {
            return this._resultReuseInformation != null;
        }

        /// <summary>
        /// Gets and sets the property ServicePreProcessingTimeInMillis. 
        /// <para>
        /// The number of milliseconds that Athena took to preprocess the query before submitting
        /// the query to the query engine.
        /// </para>
        /// </summary>
        public long? ServicePreProcessingTimeInMillis
        {
            get { return this._servicePreProcessingTimeInMillis; }
            set { this._servicePreProcessingTimeInMillis = value; }
        }

        // Check to see if ServicePreProcessingTimeInMillis property is set
        internal bool IsSetServicePreProcessingTimeInMillis()
        {
            return this._servicePreProcessingTimeInMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceProcessingTimeInMillis. 
        /// <para>
        /// The number of milliseconds that Athena took to finalize and publish the query results
        /// after the query engine finished running the query.
        /// </para>
        /// </summary>
        public long? ServiceProcessingTimeInMillis
        {
            get { return this._serviceProcessingTimeInMillis; }
            set { this._serviceProcessingTimeInMillis = value; }
        }

        // Check to see if ServiceProcessingTimeInMillis property is set
        internal bool IsSetServiceProcessingTimeInMillis()
        {
            return this._serviceProcessingTimeInMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalExecutionTimeInMillis. 
        /// <para>
        /// The number of milliseconds that Athena took to run the query.
        /// </para>
        /// </summary>
        public long? TotalExecutionTimeInMillis
        {
            get { return this._totalExecutionTimeInMillis; }
            set { this._totalExecutionTimeInMillis = value; }
        }

        // Check to see if TotalExecutionTimeInMillis property is set
        internal bool IsSetTotalExecutionTimeInMillis()
        {
            return this._totalExecutionTimeInMillis.HasValue; 
        }

    }
}