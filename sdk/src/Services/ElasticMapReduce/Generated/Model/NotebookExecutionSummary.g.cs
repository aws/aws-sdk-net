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
    /// Details for a notebook execution. The details include information such as the unique
    /// ID and status of the notebook execution.
    /// </summary>
    public partial class NotebookExecutionSummary
    {
        /// <summary>
        /// Gets and sets the property EditorId. 
        /// <para>
        /// The unique identifier of the editor associated with the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EditorId { get; set; }

        /// <summary>
        /// Checks to see if the EditorId property is set.
        /// </summary>
        internal bool IsSetEditorId() => this.EditorId != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when notebook execution started.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionEngineId. 
        /// <para>
        /// The unique ID of the execution engine for the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string ExecutionEngineId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionEngineId property is set.
        /// </summary>
        internal bool IsSetExecutionEngineId() => this.ExecutionEngineId != null;

        /// <summary>
        /// Gets and sets the property NotebookExecutionId. 
        /// <para>
        /// The unique identifier of the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NotebookExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the NotebookExecutionId property is set.
        /// </summary>
        internal bool IsSetNotebookExecutionId() => this.NotebookExecutionId != null;

        /// <summary>
        /// Gets and sets the property NotebookExecutionName. 
        /// <para>
        /// The name of the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NotebookExecutionName { get; set; }

        /// <summary>
        /// Checks to see if the NotebookExecutionName property is set.
        /// </summary>
        internal bool IsSetNotebookExecutionName() => this.NotebookExecutionName != null;

        /// <summary>
        /// Gets and sets the property NotebookS3Location. 
        /// <para>
        /// The Amazon S3 location that stores the notebook execution input.
        /// </para>
        /// </summary>
        public NotebookS3LocationForOutput NotebookS3Location { get; set; }

        /// <summary>
        /// Checks to see if the NotebookS3Location property is set.
        /// </summary>
        internal bool IsSetNotebookS3Location() => this.NotebookS3Location != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when notebook execution started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the notebook execution.
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
    }
}
