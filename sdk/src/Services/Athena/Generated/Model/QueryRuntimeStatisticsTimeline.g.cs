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
    /// Timeline statistics such as query queue time, planning time, execution time, service
    /// processing time, and total execution time.
    /// </summary>
    public partial class QueryRuntimeStatisticsTimeline
    {
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
        /// Gets and sets the property ServicePreProcessingTimeInMillis. 
        /// <para>
        ///  The number of milliseconds that Athena spends on preprocessing before it submits
        /// the query to the engine. 
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
