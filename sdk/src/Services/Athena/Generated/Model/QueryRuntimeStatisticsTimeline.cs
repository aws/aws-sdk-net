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
    /// Timeline statistics such as query queue time, planning time, execution time, service
    /// processing time, and total execution time.
    /// </summary>
    public partial class QueryRuntimeStatisticsTimeline
    {
        private long? _engineExecutionTimeInMillis;
        private long? _queryPlanningTimeInMillis;
        private long? _queryQueueTimeInMillis;
        private long? _servicePreProcessingTimeInMillis;
        private long? _serviceProcessingTimeInMillis;
        private long? _totalExecutionTimeInMillis;

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
        /// Gets and sets the property ServicePreProcessingTimeInMillis. 
        /// <para>
        ///  The number of milliseconds that Athena spends on preprocessing before it submits
        /// the query to the engine. 
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