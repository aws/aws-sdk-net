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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains summary information about a pipeline execution.
    /// </summary>
    public partial class PipelineExecutionSummary
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time the pipeline execution completed, in Unix epoch time.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionPriority. 
        /// <para>
        /// Scheduling priority for the execution. When not specified, defaults to lowest priority.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public int? ExecutionPriority { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionPriority property is set.
        /// </summary>
        internal bool IsSetExecutionPriority() => this.ExecutionPriority.HasValue;

        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The unique identifier of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string PipelineExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the PipelineExecutionId property is set.
        /// </summary>
        internal bool IsSetPipelineExecutionId() => this.PipelineExecutionId != null;

        /// <summary>
        /// Gets and sets the property PipelineVersion. 
        /// <para>
        /// The pipeline version this execution ran against.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string PipelineVersion { get; set; }

        /// <summary>
        /// Checks to see if the PipelineVersion property is set.
        /// </summary>
        internal bool IsSetPipelineVersion() => this.PipelineVersion != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the pipeline execution started, in Unix epoch time.
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
        /// The current execution status of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PipelineExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
