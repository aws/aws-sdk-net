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
    /// This is the response object from the DescribePipelineExecution operation.
    /// </summary>
    public partial class DescribePipelineExecutionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ComputeNodeExecutionDetails. 
        /// <para>
        /// A list of compute node execution details within this pipeline execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ComputeNodeExecutionDetails> ComputeNodeExecutionDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<ComputeNodeExecutionDetails>() : null;

        /// <summary>
        /// Checks to see if the ComputeNodeExecutionDetails property is set.
        /// </summary>
        internal bool IsSetComputeNodeExecutionDetails() => this.ComputeNodeExecutionDetails != null && (this.ComputeNodeExecutionDetails.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

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
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string PipelineName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineName property is set.
        /// </summary>
        internal bool IsSetPipelineName() => this.PipelineName != null;

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
        /// Gets and sets the property RequestEnvironmentVariables. 
        /// <para>
        /// The environment variables provided as input for the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public ExecutionEnvironmentVariables RequestEnvironmentVariables { get; set; }

        /// <summary>
        /// Checks to see if the RequestEnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetRequestEnvironmentVariables() => this.RequestEnvironmentVariables != null;

        /// <summary>
        /// Gets and sets the property RequestMountOverrides. 
        /// <para>
        /// The mount overrides provided as input for the pipeline execution. Present when mount
        /// overrides were supplied at execution time.
        /// </para>
        /// </summary>
        public MountOverrides RequestMountOverrides { get; set; }

        /// <summary>
        /// Checks to see if the RequestMountOverrides property is set.
        /// </summary>
        internal bool IsSetRequestMountOverrides() => this.RequestMountOverrides != null;

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

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;
    }
}
