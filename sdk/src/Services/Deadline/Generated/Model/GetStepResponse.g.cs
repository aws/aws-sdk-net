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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// This is the response object from the GetStep operation.
    /// </summary>
    public partial class GetStepResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. The date and time the resource was created.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. The user or system that created this resource.
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property DependencyCounts. The number of dependencies in the step.
        /// </summary>
        public DependencyCounts DependencyCounts { get; set; }

        /// <summary>
        /// Checks to see if the DependencyCounts property is set.
        /// </summary>
        internal bool IsSetDependencyCounts() => this.DependencyCounts != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the step.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndedAt. The date and time the resource ended running.
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LifecycleStatus. The life cycle status of the step.
        /// </summary>
        [AWSProperty(Required = true)]
        public StepLifecycleStatus LifecycleStatus { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleStatus property is set.
        /// </summary>
        internal bool IsSetLifecycleStatus() => this.LifecycleStatus != null;

        /// <summary>
        /// Gets and sets the property LifecycleStatusMessage. A message that describes the lifecycle
        /// status of the step.
        /// </summary>
        public string LifecycleStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleStatusMessage property is set.
        /// </summary>
        internal bool IsSetLifecycleStatusMessage() => this.LifecycleStatusMessage != null;

        /// <summary>
        /// Gets and sets the property Name. The name of the step.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParameterSpace. A list of step parameters and the combination
        /// expression for the step.
        /// </summary>
        public ParameterSpace ParameterSpace { get; set; }

        /// <summary>
        /// Checks to see if the ParameterSpace property is set.
        /// </summary>
        internal bool IsSetParameterSpace() => this.ParameterSpace != null;

        /// <summary>
        /// Gets and sets the property RequiredCapabilities. The required capabilities of the
        /// step.
        /// </summary>
        public StepRequiredCapabilities RequiredCapabilities { get; set; }

        /// <summary>
        /// Checks to see if the RequiredCapabilities property is set.
        /// </summary>
        internal bool IsSetRequiredCapabilities() => this.RequiredCapabilities != null;

        /// <summary>
        /// Gets and sets the property StartedAt. The date and time the resource started running.
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StepId. The step ID.
        /// </summary>
        [AWSProperty(Required = true)]
        public string StepId { get; set; }

        /// <summary>
        /// Checks to see if the StepId property is set.
        /// </summary>
        internal bool IsSetStepId() => this.StepId != null;

        /// <summary>
        /// Gets and sets the property TargetTaskRunStatus. The task status with which the job
        /// started.
        /// </summary>
        public StepTargetTaskRunStatus TargetTaskRunStatus { get; set; }

        /// <summary>
        /// Checks to see if the TargetTaskRunStatus property is set.
        /// </summary>
        internal bool IsSetTargetTaskRunStatus() => this.TargetTaskRunStatus != null;

        /// <summary>
        /// Gets and sets the property TaskFailureRetryCount. The total number of times tasks
        /// from the step failed and were retried.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? TaskFailureRetryCount { get; set; }

        /// <summary>
        /// Checks to see if the TaskFailureRetryCount property is set.
        /// </summary>
        internal bool IsSetTaskFailureRetryCount() => this.TaskFailureRetryCount.HasValue;

        /// <summary>
        /// Gets and sets the property TaskRunStatus. The task run status for the job.
        /// </summary>
        [AWSProperty(Required = true)]
        public TaskRunStatus TaskRunStatus { get; set; }

        /// <summary>
        /// Checks to see if the TaskRunStatus property is set.
        /// </summary>
        internal bool IsSetTaskRunStatus() => this.TaskRunStatus != null;

        /// <summary>
        /// Gets and sets the property TaskRunStatusCounts. The number of tasks running on the
        /// job.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, int> TaskRunStatusCounts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the TaskRunStatusCounts property is set.
        /// </summary>
        internal bool IsSetTaskRunStatusCounts() => this.TaskRunStatusCounts != null && (this.TaskRunStatusCounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. The date and time the resource was updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. The user or system that updated this resource.
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;
    }
}
