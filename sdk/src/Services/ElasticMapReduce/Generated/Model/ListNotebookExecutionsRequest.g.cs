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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the ListNotebookExecutions operation. Provides summaries
    /// of all notebook executions. You can filter the list based on multiple criteria such
    /// as status, time range, and editor id. Returns a maximum of 50 notebook executions
    /// and a marker to track the paging of a longer notebook execution list across multiple
    /// <c>ListNotebookExecutions</c> calls.
    /// </summary>
    public partial class ListNotebookExecutionsRequest : AmazonElasticMapReduceRequest
    {
        /// <summary>
        /// Gets and sets the property EditorId. 
        /// <para>
        /// The unique ID of the editor associated with the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EditorId { get; set; }

        /// <summary>
        /// Checks to see if the EditorId property is set.
        /// </summary>
        internal bool IsSetEditorId() => this.EditorId != null;

        /// <summary>
        /// Gets and sets the property ExecutionEngineId. 
        /// <para>
        /// The unique ID of the execution engine.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string ExecutionEngineId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionEngineId property is set.
        /// </summary>
        internal bool IsSetExecutionEngineId() => this.ExecutionEngineId != null;

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The beginning of time range filter for listing notebook executions. The default is
        /// the timestamp of 30 days ago.
        /// </para>
        /// </summary>
        public DateTime? From { get; set; }

        /// <summary>
        /// Checks to see if the From property is set.
        /// </summary>
        internal bool IsSetFrom() => this.From.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token, returned by a previous <c>ListNotebookExecutions</c> call, that
        /// indicates the start of the list for this <c>ListNotebookExecutions</c> call.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status filter for listing notebook executions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>START_PENDING</c> indicates that the cluster has received the execution request
        /// but execution has not begun.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STARTING</c> indicates that the execution is starting on the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c> indicates that the execution is being processed by the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FINISHING</c> indicates that execution processing is in the final stages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FINISHED</c> indicates that the execution has completed without error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILING</c> indicates that the execution is failing and will not finish successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> indicates that the execution failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOP_PENDING</c> indicates that the cluster has received a <c>StopNotebookExecution</c>
        /// request and the stop is pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPING</c> indicates that the cluster is in the process of stopping the execution
        /// as a result of a <c>StopNotebookExecution</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPED</c> indicates that the execution stopped because of a <c>StopNotebookExecution</c>
        /// request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public NotebookExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The end of time range filter for listing notebook executions. The default is the current
        /// timestamp.
        /// </para>
        /// </summary>
        public DateTime? To { get; set; }

        /// <summary>
        /// Checks to see if the To property is set.
        /// </summary>
        internal bool IsSetTo() => this.To.HasValue;
    }
}
