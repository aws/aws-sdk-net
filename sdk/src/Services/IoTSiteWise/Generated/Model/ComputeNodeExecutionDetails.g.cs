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
    /// Contains detailed execution information for a compute node within a pipeline execution.
    /// </summary>
    public partial class ComputeNodeExecutionDetails
    {
        /// <summary>
        /// Gets and sets the property ComputeNodeName. 
        /// <para>
        /// The name of the compute node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ComputeNodeName { get; set; }

        /// <summary>
        /// Checks to see if the ComputeNodeName property is set.
        /// </summary>
        internal bool IsSetComputeNodeName() => this.ComputeNodeName != null;

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// A list of compute node names that this node depends on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public List<string> DependsOn { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DependsOn property is set.
        /// </summary>
        internal bool IsSetDependsOn() => this.DependsOn != null && (this.DependsOn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time the compute node execution completed, in Unix epoch time.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionEnvironmentVariables. 
        /// <para>
        /// The fully resolved environment variables used for this compute node execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public Dictionary<string, string> ExecutionEnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ExecutionEnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetExecutionEnvironmentVariables() => this.ExecutionEnvironmentVariables != null && (this.ExecutionEnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExecutionMounts. 
        /// <para>
        /// The fully resolved mounts used for this compute node execution, after merging task-defined
        /// mounts with any execution-level mount overrides. Each mount attaches an external data
        /// source to the container filesystem at a relative path under the service-owned mount
        /// root.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<Mount> ExecutionMounts { get; set; } = AWSConfigs.InitializeCollections ? new List<Mount>() : null;

        /// <summary>
        /// Checks to see if the ExecutionMounts property is set.
        /// </summary>
        internal bool IsSetExecutionMounts() => this.ExecutionMounts != null && (this.ExecutionMounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the compute node execution started, in Unix epoch time.
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
        /// The current execution status of the compute node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComputeNodeExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The ARN of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string TaskArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskArn property is set.
        /// </summary>
        internal bool IsSetTaskArn() => this.TaskArn != null;

        /// <summary>
        /// Gets and sets the property TaskName. 
        /// <para>
        /// The name of the task executed for this compute node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string TaskName { get; set; }

        /// <summary>
        /// Checks to see if the TaskName property is set.
        /// </summary>
        internal bool IsSetTaskName() => this.TaskName != null;

        /// <summary>
        /// Gets and sets the property TaskVersion. 
        /// <para>
        /// The task version that executed for this compute node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string TaskVersion { get; set; }

        /// <summary>
        /// Checks to see if the TaskVersion property is set.
        /// </summary>
        internal bool IsSetTaskVersion() => this.TaskVersion != null;
    }
}
