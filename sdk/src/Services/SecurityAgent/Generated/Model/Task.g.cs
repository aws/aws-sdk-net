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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Represents an individual security test task within a pentest job. Each task targets
    /// a specific risk type or endpoint and executes independently.
    /// </summary>
    public partial class Task
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space.
        /// </para>
        /// </summary>
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The list of categories assigned to the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Category> Categories { get; set; } = AWSConfigs.InitializeCollections ? new List<Category>() : null;

        /// <summary>
        /// Checks to see if the Categories property is set.
        /// </summary>
        internal bool IsSetCategories() => this.Categories != null && (this.Categories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the task was created, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the task.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The current execution status of the task.
        /// </para>
        /// </summary>
        public TaskExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property LogsLocation. 
        /// <para>
        /// The location of the task execution logs.
        /// </para>
        /// </summary>
        public LogLocation LogsLocation { get; set; }

        /// <summary>
        /// Checks to see if the LogsLocation property is set.
        /// </summary>
        internal bool IsSetLogsLocation() => this.LogsLocation != null;

        /// <summary>
        /// Gets and sets the property PentestId. 
        /// <para>
        /// The unique identifier of the pentest associated with the task.
        /// </para>
        /// </summary>
        public string PentestId { get; set; }

        /// <summary>
        /// Checks to see if the PentestId property is set.
        /// </summary>
        internal bool IsSetPentestId() => this.PentestId != null;

        /// <summary>
        /// Gets and sets the property PentestJobId. 
        /// <para>
        /// The unique identifier of the pentest job that contains the task.
        /// </para>
        /// </summary>
        public string PentestJobId { get; set; }

        /// <summary>
        /// Checks to see if the PentestJobId property is set.
        /// </summary>
        internal bool IsSetPentestJobId() => this.PentestJobId != null;

        /// <summary>
        /// Gets and sets the property RiskType. 
        /// <para>
        /// The type of security risk the task is testing for.
        /// </para>
        /// </summary>
        public RiskType RiskType { get; set; }

        /// <summary>
        /// Checks to see if the RiskType property is set.
        /// </summary>
        internal bool IsSetRiskType() => this.RiskType != null;

        /// <summary>
        /// Gets and sets the property TargetEndpoint. 
        /// <para>
        /// The target endpoint being tested by the task.
        /// </para>
        /// </summary>
        public Endpoint TargetEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the TargetEndpoint property is set.
        /// </summary>
        internal bool IsSetTargetEndpoint() => this.TargetEndpoint != null;

        /// <summary>
        /// Gets and sets the property TaskHours. 
        /// <para>
        /// The number of active work hours consumed by the task during execution.
        /// </para>
        /// </summary>
        public double? TaskHours { get; set; }

        /// <summary>
        /// Checks to see if the TaskHours property is set.
        /// </summary>
        internal bool IsSetTaskHours() => this.TaskHours.HasValue;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the task.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the task was last updated, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
